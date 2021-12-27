using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;
    public float addScore;
    // Start is called before the first frame update
    void Start()
    {
        addScore = 0;
        scoretext.text = "Score :" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int points)
    {
        addScore += points;
        UpdateScore(addScore);
    }

    public void UpdateScore(float playerScore)
    {
        scoretext.text = "Score :" + playerScore.ToString();
    }
}
