using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanMovementUp : MonoBehaviour
{
    public GameObject fan;
    public Rigidbody2D top;

    [Range(-10.0f, 10.0f)]
    public float h�z;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Etkile�imFan");

        top.AddForce(Vector2.up * h�z);
       
    }
}
