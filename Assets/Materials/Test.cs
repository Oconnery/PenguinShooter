using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour { //MonoBehavious just means that it's a script in Unity. It allows us to use it with Unity

    // Put Variables here
    
    public int age = 21;
    public float height;
    public string name;
    public bool isFemale;
    public GameObject myCharacter;

    //Declaring arrays in C#
    int[] arr = new int[10];

	// Use this for initialization
	void Start () {
        age += 5 ;
        height = 6.57f; // f is required for float for some reason
        name = "Augusto";

	}
	
	// Update is called once per frame
	void Update () {

        age++;

        if (isFemale == true)
        {
            isFemale = false;
        }
	}

    void MyCharacter ()
    {
        print("The age is " + age);
    }

}