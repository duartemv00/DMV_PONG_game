using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIA : MonoBehaviour
{
    public float playerVel;

    public GameObject ball;

    private void FixedUpdate(){
        
        float ballPos = this.ball.transform.position.y;
        float playerPos = this.transform.position.y;
        
        //this.transform.position = new Vector3(600,ball.transform.position.y,0);

        if(playerPos<ballPos+10 && playerPos>ballPos-10){
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        } else if(playerPos<ballPos) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * playerVel;
        } else {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1) * playerVel;
        }

        //if(Mathf.abs(playerPos - ballPos)>50){}

        
    }
}
