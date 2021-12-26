using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public KeyCode upButton = KeyCode.W;
    public KeyCode downButton = KeyCode.S;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;
   

    private Rigidbody2D rb;
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(upButton))
        {
            rb.transform.Translate(0, speed, Time.deltaTime);
        }
         if (Input.GetKey(rightButton))
        {
            rb.transform.Translate(speed, 0, Time.deltaTime);
        }
         if (Input.GetKey(leftButton))
        {
            rb.transform.Translate(-speed, 0, Time.deltaTime);
        }
         if (Input.GetKey(downButton))
        {
            rb.transform.Translate(0, -speed, Time.deltaTime);
        }
    }
}
