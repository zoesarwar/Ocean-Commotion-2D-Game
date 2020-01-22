using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLocation : MonoBehaviour
{
   public GameObject coin;

    void Start(){
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}
