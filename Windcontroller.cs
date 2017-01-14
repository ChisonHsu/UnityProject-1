using UnityEngine;
using System.Collections;

public class Windcontroller : MonoBehaviour {//Wind上的Script作為觸發用
    public GameObject Player;
    public Rigidbody Playerrigid;
    private float Drag = 200;

    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        Playerrigid = Player.GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider collider)
    {
        print("Enter");//test trigger
        if (collider.tag == "Player")
        {
            Playerrigid.useGravity = false;
            Playerrigid.AddForce(0,Drag,0);
            Debug.Log("Windflow");
        }        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Playerrigid.useGravity = true;
            Playerrigid.AddForce(0, -1*Drag, 0);
            Debug.Log("Exit");
        }
        
    }
}
