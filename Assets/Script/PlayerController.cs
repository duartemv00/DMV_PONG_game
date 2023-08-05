using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerVel;

    public string controller;

    private void FixedUpdate(){
        float v = Input.GetAxisRaw(controller);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v) * playerVel;
    }
}
