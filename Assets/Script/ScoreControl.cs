using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreControl : MonoBehaviour
{
    private int player01Points = 0;
    private int player02Points = 0;

    public GameObject txtPoints01;
    public GameObject txtPoints02;

    public int objectivePoints;

    void Update()
    {
        if(this.player01Points >= this.objectivePoints || this.player02Points >= this.objectivePoints){
            SceneManager.LoadScene("GameOver");
        }
    }

    private void FixedUpdate(){
        TMP_Text pointTag1 = this.txtPoints01.GetComponent<TMP_Text>();
        pointTag1.text = this.player01Points.ToString();

        TMP_Text pointTag2 = this.txtPoints02.GetComponent<TMP_Text>();
        pointTag2.text = this.player02Points.ToString();
    }

    public void GolPlayer01(){
        this.player01Points++;
    }

    public void GolPlayer02(){
        this.player02Points++;
    }
}
