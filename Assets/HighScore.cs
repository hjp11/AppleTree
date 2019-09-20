using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    // Start is called before the first frame update
    void Awake()
    {
        if (PlayerPrefs.HasKey("ApplePickerHighscore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighscore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
        
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score:" + score;
        if(score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
    }
}
