using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkGenerator : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;
    public float timeBtwnShark;
    public float startTimeBtwnShark;
    public float speedUpShark;
    public float minTime = 0.50f;


    private void Update(){
        if(timeBtwnShark <=0){
            int random = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[random], transform.position, Quaternion.identity);
            timeBtwnShark = startTimeBtwnShark;
            if(startTimeBtwnShark > minTime){
            startTimeBtwnShark -= speedUpShark;
        }
        }
        else{
            timeBtwnShark -= Time.deltaTime;
        }
}
}
