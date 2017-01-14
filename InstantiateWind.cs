using UnityEngine;
using System.Collections;

public class InstantiateWind : MonoBehaviour {//floor上的Script生成Wind用
    public GameObject Wind;
	// Use this for initialization
	void Start () {
        Wind = GameObject.FindWithTag("Wind");
        InvokeRepeating("SpawnWind", 5f, 5f);//自第5秒開始執行SpawnWind,週期為5秒
	}
    void SpawnWind()
    {
        Instantiate(Wind, transform.position, new Quaternion(0, 0, 0, 0));//自此地重複生成物件Wind
    }
	// Update is called once per frame
	void Update () {
	
	}
}
