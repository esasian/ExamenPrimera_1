using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private float ballMove = 0.1f;
    void Start () {
		
	}
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(ballMove, 0, 0);
           // print("A");
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(-ballMove, 0, 0);
            //print("D");
        }

        if (transform.position.y <= -3.014445f)
        {
            ballMove = 0f;
          //  print("caida");
        }
         

    }
}
