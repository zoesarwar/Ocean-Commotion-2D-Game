﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarFishFunction : MonoBehaviour
{
   public int score = 5;
   public float speed;
   public Text TextBox;

   private void Update(){
       transform.Translate(Vector2.left * speed * Time.deltaTime);
   }

   private void Start() {
        this.GetComponent<SpriteRenderer>().sortingOrder = 10;

   }

   public void OnCollisionEnter2D(Collision2D other){
       Debug.Log("iscalled");
       if(other.gameObject.tag == "Fish"){
           other.gameObject.GetComponent<PlayerFishFunction>().health += score;
           Debug.Log(other.gameObject.GetComponent<PlayerFishFunction>().health);
           Destroy(gameObject);
           TextBox = GameObject.Find("ScoreNumber").GetComponent<Text>();
           TextBox.text = other.gameObject.GetComponent<PlayerFishFunction>().health.ToString();
       }
   }
}