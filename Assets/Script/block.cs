using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block : MonoBehaviour
{
    private Rigidbody2D rb;
    public score score;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MonoBehaviour camMono = this.gameObject.GetComponent<MonoBehaviour>();
            Debug.Log("Tabrak");
            score.GetComponent<score>().AddScore(1);
            this.gameObject.SetActive(false);
            Invoke("wait", 3.0f);
        }
    }

    private void wait()
    {
        this.gameObject.transform.position = new Vector3(Random.Range(-6.0f, 7.0f), Random.Range(-3.0f, 3.5f), 0);
        this.gameObject.SetActive(true);
    }
}