using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanMovement : MonoBehaviour
{
    public GameObject fan;
    public Rigidbody2D top;
    void Start()
    {
        
    }

    void Update()
    {
        fan.transform.Rotate(0,0,-2);
        
    }
    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        top.AddForce(Vector2.right);
        Debug.Log("Etkile�imFan");
    }
    */
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Etkile�imFan");
        top.AddForce(Vector2.right);       
    }
   
}
