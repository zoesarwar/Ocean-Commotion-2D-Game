using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoingGenerator : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;
    private float timeBtwnCoin;
    public float startTimeBtwnCoin;
    public float speedUpCoin;
    public float minTime = 0.50f;


    private void Update(){
        if(timeBtwnCoin <=0){
            int random = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[random], transform.position, Quaternion.identity);
            timeBtwnCoin = startTimeBtwnCoin;
            if(startTimeBtwnCoin > minTime){
            startTimeBtwnCoin -= speedUpCoin;
        }
        }
        else{
            timeBtwnCoin -= Time.deltaTime;
        }
    }
}

