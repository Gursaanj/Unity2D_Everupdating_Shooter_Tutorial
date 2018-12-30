using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float speed;
    float DestroyPoint;
    float DestroyPoint_2;
    public GameObject Bullet2;
    public GameObject BigBlock;
    Vector3 size;
    float radMove;


    // Use this for initialization
    void Start()
    {
        DestroyPoint = gameObject.transform.position.x + 27f;
        DestroyPoint_2 = gameObject.transform.position.x - 28f;
        size = GetComponent<Collider2D>().bounds.size;
        radMove = size.x / 2;

    //    StartCoroutine(Waity(0.2f));
    //    gameObject.GetComponent<Collider2D>().enabled = false;
    }

    //IEnumerator Waity(float wait)
    //{
    //    yield return new WaitForSeconds(wait);
    //    gameObject.GetComponent<Collider2D>().enabled = true;

    //}


	// Update is called once per frame
	void Update () {
        MoveRight();
        Scaling();
        Destroying();
	}
    
    public void MoveRight()
    {
        Vector2 amountToMove = new Vector2(Time.deltaTime* speed, 0 );
        transform.Translate(amountToMove);
    }

    public void Scaling()
    {
        if (transform.localScale.x <= 12.0f && transform.localScale.y <= 12.0f)
        {
          transform.localScale += new Vector3(0.9f, 0.8f, 0);
        }

    }

    public void Destroying()
    {
        if (transform.position.x >= DestroyPoint || transform.position.x <= DestroyPoint_2)
            Destroy(gameObject);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet2")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            transform.position = new Vector3(transform.position.x + radMove, transform.position.y, transform.position.z);
            Instantiate(BigBlock, transform.position, transform.rotation);
        }

        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
        }

    }
}


