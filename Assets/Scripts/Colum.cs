using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Colum : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    public class ExampleClass : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D coll)
        {

            if (coll.gameObject.tag == "Enemy")
                coll.gameObject.SendMessage("ApplyDamage", 10);

        }
    }
}
