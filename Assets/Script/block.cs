using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block : MonoBehaviour
{
    private Rigidbody2D rb;
    public score score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger!");
        if (collision.gameObject.CompareTag("Player"))
        {
            score.GetComponent<score>().AddScore(1);
            Debug.Log("Tabrak");
            this.gameObject.SetActive(false);
        }
    }
}
