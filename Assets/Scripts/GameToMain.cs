using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameToMain : MonoBehaviour
{
    public int x;

    public void ToMain()
    {
        if(Time.timeScale == 1){
            Time.timeScale = 1;
        }
         if(Time.timeScale == 0){
            Time.timeScale = 0;
        }
}
}