using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour
{
    public AudioSource playerSound;
    public AudioSource wallSound;

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player"){
            this.playerSound.Play();
        } else {
            this.wallSound.Play();
        }
    }
}
