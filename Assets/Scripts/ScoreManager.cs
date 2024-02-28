using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
    }

    public void increment()
    {
        score++;
        text.text = score.ToString();
        if(score == 10)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void decrement()
    {
        score--;
        if(score < 0)
        {
            score = 0;
        }
        text.text = score.ToString();
    }
    public int getScore()
    {
        return score;
    }
}
