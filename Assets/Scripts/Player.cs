using System.Collections;
using UnityEngine;


public class Player : MonoBehaviour
{
   public Rigidbody2D rigidbody;
    public float force;

   
   


    void Update()
    {
        Vector3 position = transform.position;

        if(position.y < 0)
        {
            Application.LoadLevel(0);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

   
    void OnCollisionEnter2D(Collision2D col)
        {
        if (col.gameObject.tag == "tube")
            {
                Application.LoadLevel(0);
            }
            
        
    }
}



