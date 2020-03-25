using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
   public Rigidbody2D rigidbody;
    public float force;

    
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    
}
