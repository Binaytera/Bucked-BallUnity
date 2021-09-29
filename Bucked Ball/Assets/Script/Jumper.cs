using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody2D top;

    [Range(-10.0f, 10.0f)]
    public float h�z;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Etkile�im Top");
      
        top.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")+h�z);
        
    }
}
