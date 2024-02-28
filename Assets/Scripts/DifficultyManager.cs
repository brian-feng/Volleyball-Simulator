using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager instance;
    public TextMeshProUGUI text;
    public Slider slider;
    private float difficulty;
    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

    }
    public void change()
    {
        difficulty = slider.value;
        text.text = ((int)difficulty).ToString();
    }

    public float getDifficulty()
    {
        return difficulty;
    }
}
