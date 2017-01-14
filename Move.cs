using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.transform.Translate (10*Time.deltaTime, 5*Time.deltaTime, 0);
	}
}
