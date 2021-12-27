using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 1f;

    private Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        mousePosition = Input.mousePosition;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rb.transform.position = Vector2.MoveTowards(rb.transform.position, mousePosition, speed * Time.deltaTime);
    }
   
}
