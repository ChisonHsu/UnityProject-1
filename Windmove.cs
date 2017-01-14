using UnityEngine;
using System.Collections;

public class Windmove : MonoBehaviour {
    private float WindVelocity = 10f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(0, WindVelocity* Time.deltaTime, 0);
	}

}
