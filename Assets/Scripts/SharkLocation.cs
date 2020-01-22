using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkLocation : MonoBehaviour
{
   public GameObject shark;

    void Start(){
        Instantiate(shark, transform.position, Quaternion.identity);
    }
}

