using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float bulletSpeed = 7;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        rigidbody2D.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }

   void OnTriggerEnter2D(Collider2D collider)
   {
    if(collider.gameObject.tag == "Player")
    {
        return;
    }
    if(collider.gameObject.tag == "MuerteBala")
    {
        Destroy(collider.gameObject);
    }

    Destroy(gameObject);
   }
}

