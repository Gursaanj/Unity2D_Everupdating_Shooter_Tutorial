using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speedy;
    Vector3 size;
    float plusDist;
    Vector3 placeHere;

    // Use this for initialization
    void Start() {
        size = GetComponent<Collider2D>().bounds.size;

    }

    // Update is called once per frame
    void Update() {
        plusDist = transform.position.x + size.x;
        placeHere = new Vector3(plusDist, transform.position.y, transform.position.z);
        if (Input.GetButtonDown("Shoot"))
        {
            Shoot();
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -9.0f)
        {
            Vector2 amountToMove = new Vector2(0,-Time.deltaTime* speedy);
            transform.Translate(amountToMove);
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 9.0f)
        {
            Vector2 amountToMove = new Vector2(0, Time.deltaTime * speedy);
            transform.Translate(amountToMove);
        }
     
    }

    // Called when bullet hits the Target 
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }
    void Shoot() 
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        Instantiate(bulletPrefab, placeHere, transform.rotation);
        //StartCoroutine(ShooTime(0.05F));
    }

    //IEnumerator ShooTime(float shooty)
    //{
    //    yield return new WaitForSeconds(shooty);
    //    gameObject.GetComponent<Collider2D>().enabled = true;
    //}
}


