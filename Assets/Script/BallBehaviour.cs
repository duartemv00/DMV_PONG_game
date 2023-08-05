using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float movVelocity;
    public float velExtra;
    public float velExtraMax;

    int hitCounter = 0;

    void Start()
    {
        StartCoroutine(this.InitiateBall());
    }

    public IEnumerator InitiateBall(bool startPlayer1 = true){
        this.InitialBallPosition(startPlayer1);
        
        this.hitCounter = 0;

        yield return new WaitForSeconds(2);

        if(startPlayer1){
            this.MoveBall(new Vector2(-1,0));
        } else {
            this.MoveBall(new Vector2(1,0));
        }
    }

    public void MoveBall(Vector2 dir){
        dir = dir.normalized;

        float vel = this.movVelocity + this.hitCounter * velExtra;

        Rigidbody2D rb2D = this.gameObject.GetComponent<Rigidbody2D>();

        rb2D.velocity = dir * vel;
    }
    
    public void IncreaseHits(){
        if(this.hitCounter * this.velExtra <= this.velExtraMax){
            this.hitCounter++;
        }
    }

    public void InitialBallPosition(bool startPlayer1){
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        if(startPlayer1){
            this.gameObject.transform.localPosition = new Vector3(-100,0,0);
        } else {
            this.gameObject.transform.localPosition = new Vector3(100,0,0);
        }
    }

}
