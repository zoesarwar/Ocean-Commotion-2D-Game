using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainToGame : MonoBehaviour
{
    public void ToGame()
    {
        if(Time.timeScale == 1){
            Time.timeScale = 1;
        }
         if(Time.timeScale == 0){
            Time.timeScale = 0;
        }
}
}