using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    float horizontalspeed = 30.0f;
    float verticalspeed = 10.0f;
    int numberFired = 0;

    public float forceMultiplier = 10.0f;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUILayout.Label("Horizontal speed is:" + horizontalspeed);
        horizontalspeed = GUILayout.HorizontalSlider(horizontalspeed, 0 ,200);

        GUILayout.Label("Vertical speed is:" + verticalspeed);
        verticalspeed = GUILayout.HorizontalSlider(verticalspeed, 0, 50);

        if(GUILayout.Button ("Fire"))
        {
            GameObject newPenguin = (GameObject) Instantiate (Resources.Load("PenguinPrefab"));
            newPenguin.transform.position = gameObject.transform.position + new Vector3(0f,0.2f,0f);
            newPenguin.GetComponent<Rigidbody>().AddForce(new Vector3 (horizontalspeed, verticalspeed, 0)* forceMultiplier);
        }
    }
}
