using UnityEngine;
using System.Collections;

public class Penguin : MonoBehaviour {

    Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {

        myRigidbody = gameObject.GetComponent<Rigidbody> ();
        
	}
	
	// Update is called once per frame
	void Update () {
	
        if (myRigidbody.IsSleeping())
        {
            //Destroy.myRigidbody;
        }
	}
}
