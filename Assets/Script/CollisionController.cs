using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallBehaviour ballBehaviour;
    public ScoreControl scoreControl;

    void Rebote(Collision2D c2D){
        Vector3 posicionPelota = this.transform.position;
        Vector3 posicionRaqueta = c2D.gameObject.transform.position;
        float alturaRaqueta = c2D.collider.bounds.size.y;

        float x;
        if(c2D.gameObject.name == "Player01"){
            x = 1;
        } else {
            x = -1;
        }

        float y = (posicionPelota.y - posicionRaqueta.y) / alturaRaqueta;

        this.ballBehaviour.IncreaseHits();
        this.ballBehaviour.MoveBall(new Vector2(x,y));
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "Player01" || collision.gameObject.name == "Player02"){
            this.Rebote(collision);
        } else if(collision.gameObject.name == "LeftWall"){
            this.scoreControl.GolPlayer02();
            StartCoroutine(this.ballBehaviour.InitiateBall(true));
        } else if(collision.gameObject.name == "RightWall"){
            this.scoreControl.GolPlayer01();
            StartCoroutine(this.ballBehaviour.InitiateBall(false));
        }
    }
}
