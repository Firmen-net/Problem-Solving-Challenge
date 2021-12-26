using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   // public float speed = 100;
    private Rigidbody2D rb;
    Vector3 lastvelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(speed, speed));
    }

    // Update is called once per frame
    void Update()
    {
        lastvelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        var speed = lastvelocity.magnitude;
        var direction = Vector3.Reflect(lastvelocity.normalized, coll.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}