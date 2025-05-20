using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //add this to access UI elements

public class GameManager : MonoBehaviour
{
    //public AudioSource music;

    //public bool startPlaying;

    //public NoteScroller NoteScroller;

    //public static GameManager instance;


    //public int currentScore;
    //public int scorePerNote = 100;

    //public int currentMultiplier;
    //public int multiplierTracker;
    //public int[] multiplierThresholds; //this will contain the value of consecutive correct notes to be pressed to level up to next multiplier

    //public Text scoreText;
    //public Text multiplierText;


    // Start is called before the first frame update
    void Start()
    {
        //instance = this;

        //scoreText.text = "Score: 0";
        //currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if(!startPlaying)
        {
            //if(Input.anyKeyDown)
            {
                //startPlaying = true;
                //  NoteScroller.hasStarted = true;

                //music.Play();
            }
        }
    }


    public void NoteHit()
    {
        Debug.Log("Note Hit");

        //if(currentMultiplier - 1 < multiplierThresholds.Length)
        {
            //multiplierTracker++;

            //f (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {//if the value of consecutive hits is greater or equal to the threshold, do this
                //multiplierTracker = 0;
                //currentMultiplier++;
            }

        }

        //need ".text" to make this work
        //multiplierText.text = "Multiplier: x" + currentMultiplier;
        

        //currentScore += scorePerNote * currentMultiplier;
        //scoreText.text = "Score: " + currentScore;
    }

    
    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        //currentMultiplier = 1;
        //multiplierTracker = 0;

        //multiplierText.text = "Multiplier: x" + currentMultiplier;
    }



}
