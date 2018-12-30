using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour {

    public GameObject bullet;
    float MyOrigin;

    // Use this for initialization
    void Start () {
        GameObject shooter = GameObject.FindWithTag("Player");
        GameObject target = GameObject.FindWithTag("Target");
        //float Origin = shooter.transform.position.x;
        //float Origin2 = target.transform.position.x;
        //MyOrigin = (Origin + Origin2)/2;
        //transform.position = new Vector3(MyOrigin, 0, 0);
        transform.localScale += new Vector3(10f, 1000f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        //col.gameObject.transform.Translate(Time.deltaTime * -10, 0, 0);
        // change speed = -speeed;
    }

}
