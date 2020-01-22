using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFishGenerator : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;
    private float timeBtwnStarFish;
    public float startTimeBtwnStarFish;
    public float speedUpStarFish;
    public float minTime = 0.50f;


    private void Update(){
        
        if(timeBtwnStarFish <=0){
            int random = Random.Range(0, ObstaclePatterns.Length);
            // GameObject tmp = Instantiate(ObstaclePatterns[random], transform.position, Quaternion.identity);
            Instantiate(ObstaclePatterns[random], transform.position, Quaternion.identity);
            // tmp.GetComponent<SpriteRenderer>().sortingOrder = 10;
            timeBtwnStarFish = startTimeBtwnStarFish;
            if(startTimeBtwnStarFish > minTime){
            startTimeBtwnStarFish -= speedUpStarFish;
        }
        }
        else{
            timeBtwnStarFish -= Time.deltaTime;
        }
    }
}
