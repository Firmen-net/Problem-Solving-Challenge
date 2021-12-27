using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMoving : MonoBehaviour
{

    public float speed = 100f;
    private Rigidbody2D rb;
    private Vector3 lastvelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(speed, speed));
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
