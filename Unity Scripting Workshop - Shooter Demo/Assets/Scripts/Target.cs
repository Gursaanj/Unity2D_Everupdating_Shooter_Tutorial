using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    float Origin;
    public GameObject bullet;
    Vector3 Size;
    Vector3 Puthere;
    float Posx;

    // Use this for initialization
    void Start () {
        Origin = transform.position.x;
        Size = GetComponent<Collider2D>().bounds.size;
        Posx = transform.position.x - Size.x;
	}

    // Called when bullet hits the Target 
    void OnCollisionEnter2D(Collision2D col)
    {
        //SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        transform.position = new Vector3(transform.position.x, Random.Range(-9f, 9f), 0);
        Puthere = new Vector3(Posx, transform.position.y, transform.position.z);
        transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, 0);
        StartCoroutine(WaitPlease(0.3F));
        gameObject.GetComponent<Collider2D>().enabled = false;
    }

    IEnumerator WaitPlease(float wait)
    {
        yield return new WaitForSeconds(wait);
        Instantiate(bullet, Puthere, transform.rotation);
        StartCoroutine(StartAgain(0.1F));
    }

    IEnumerator StartAgain(float start)
    {
        yield return new WaitForSeconds(start);
        gameObject.GetComponent<Collider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update() {
        //SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (transform.position.x > Origin  || transform.position.x < Origin)
        {
            transform.position = new Vector3(Origin, transform.position.y, 0);
        }
    }
}


