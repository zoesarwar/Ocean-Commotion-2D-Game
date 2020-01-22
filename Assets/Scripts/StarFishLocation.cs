using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFishLocation : MonoBehaviour
{
   public GameObject StarFish;

    void Start(){
        Instantiate(StarFish, transform.position, Quaternion.identity);
    }
}
