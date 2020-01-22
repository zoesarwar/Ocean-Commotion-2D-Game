using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkFunction : MonoBehaviour
{
   
   public int damage = 1;
   public float speed;
   public Text TextBox;

   private void Update(){
       transform.Translate(Vector2.left * speed * Time.deltaTime);
   }

   public void OnCollisionEnter2D(Collision2D other){
       Debug.Log("iscalled");
       if(other.gameObject.tag == "Fish"){
           other.gameObject.GetComponent<PlayerFishFunction>().life -= damage;
           Debug.Log(other.gameObject.GetComponent<PlayerFishFunction>().life);
           Destroy(gameObject);
           TextBox = GameObject.Find("LivesNumber").GetComponent<Text>();
           TextBox.text = other.gameObject.GetComponent<PlayerFishFunction>().life.ToString();
       }
       if(other.gameObject.GetComponent<PlayerFishFunction>().life == 0){

           other.gameObject.GetComponent<PlayerFishFunction>().life += 3;
           
           TextBox = GameObject.Find("GameOver").GetComponent<Text>();
           TextBox.text = other.gameObject.GetComponent<PlayerFishFunction>().GameOver.ToString();

           TextBox = GameObject.Find("YourScore").GetComponent<Text>();
           TextBox.text = other.gameObject.GetComponent<PlayerFishFunction>().YourScore.ToString();

           TextBox = GameObject.Find("FinalScore").GetComponent<Text>();
           TextBox.text = other.gameObject.GetComponent<PlayerFishFunction>().health.ToString();

           if (TextBox = GameObject.Find("FinalScore").GetComponent<Text>()){
                other.gameObject.GetComponent<PlayerFishFunction>().health *= 0;
           }

           Time.timeScale = 0;
        }
}

public void OnCollisionEnter2dAgain(Collision2D other){
    if(gameObject.GetComponent<PlayAgainButton>().Again != 0){
        other.gameObject.GetComponent<PlayerFishFunction>().life += 3;
        other.gameObject.GetComponent<PlayerFishFunction>().health *= 0;

}
}
}