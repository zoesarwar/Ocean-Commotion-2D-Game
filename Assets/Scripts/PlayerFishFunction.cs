using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFishFunction : MonoBehaviour
{
    
    private Vector2 fishPos;
    public float yMove;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 0;
    public int life = 3;
    public string GameOver = "Game Over!";
    public string YourScore = "Your Score:";

    private void Start() {
        fishPos = transform.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, fishPos, speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxHeight){
            fishPos =  new Vector2(transform.position.x, transform.position.y + yMove);
        }

        else if(Input.GetKey(KeyCode.DownArrow) && transform.position.y > minHeight){
            fishPos = new Vector2(transform.position.x, transform.position.y - yMove);
}
}
}
