using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
   public Rigidbody2D rigidbody;
    public float force;
    
public class ExampleClass : MonoBehaviour 
    {
    void OnCollisionEnter2D(Collision2D coll)
        {

        if (coll.gameObject.tag == "Enemy")
            coll.gameObject.SendMessage("ApplyDamage", 10);
        
    }
}
    



    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    
}
