using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    private int Score = 0;

   void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "SmallstarTag")
        {
            
            Score += 20;
        }
        else if (other.gameObject.tag == "LargestarTag")
        {
            Score += 80;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            Score += 10;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += 120;
        }


        this.ScoreText.text = Score.ToString();
    }
    private Text ScoreText;



    // Use this for initialization
    void Start () {

       

        this.ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {


	
	}


}
