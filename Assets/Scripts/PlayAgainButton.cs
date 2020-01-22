using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAgainButton : MonoBehaviour
{

public int Again = 0;
public int life2 = 3;
public int score2 = 0;
public Text TextBox;
public Text TextBox1;
public int health2 = 0;
public string Clear1 = " ";
public string Clear2 = " ";
public string Clear3 = " ";

    public void Play()
    {
        Time.timeScale = 1;

        TextBox = GameObject.Find("LivesNumber").GetComponent<Text>();
        TextBox.text = gameObject.GetComponent<PlayAgainButton>().life2.ToString();

        TextBox1 = GameObject.Find("ScoreNumber").GetComponent<Text>();
        TextBox1.text = gameObject.GetComponent<PlayAgainButton>().health2.ToString();

        TextBox = GameObject.Find("GameOver").GetComponent<Text>();
        TextBox.text = gameObject.GetComponent<PlayAgainButton>().Clear1.ToString();

        TextBox = GameObject.Find("YourScore").GetComponent<Text>();
        TextBox.text = gameObject.GetComponent<PlayAgainButton>().Clear2.ToString();

        TextBox = GameObject.Find("FinalScore").GetComponent<Text>();
        TextBox.text = gameObject.GetComponent<PlayAgainButton>().Clear3.ToString();

        Again =+ 1;
        //if(gameObject.GetComponent<PlayAgainButton>().Again != 0){
          //  Debug.Log("iscalled");
            //gameObject.GetComponent<PlayerFishFunction>().health =- health;
            //gameObject.GetComponent<PlayerFishFunction>().life =+ 3;

            //gameObject.GetComponent<SharkFunction>().TextBox = GameObject.Find("LivesNumber").GetComponent<Text>();
            //gameObject.GetComponent<SharkFunction>().TextBox.text = gameObject.GetComponent<PlayerFishFunction>().life.ToString();
    }
}
