using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour {

    public float speed;
    float DestroyPoint;
    float DestroyPoint_2;

    // Use this for initialization
    void Start () {
        DestroyPoint = gameObject.transform.position.x + 27f;
        DestroyPoint_2 = gameObject.transform.position.x - 28f;

    }
	
	// Update is called once per frame
	void Update () {
        MoveRight();
        Scaling();
        Destroying();
    }

    public void MoveRight()
    {
        Vector2 amountToMove = new Vector2(Time.deltaTime * speed, 0);
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

}
