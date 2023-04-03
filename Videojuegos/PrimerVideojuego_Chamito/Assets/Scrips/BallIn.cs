/*
Detect when the ball guess if it's in

Samuel Acevedo
2023-03-01
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIn : MonoBehaviour
{
    [SerializeField] Score scoreObj;
    [SerializeField] AudioSource scoreSoundEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Detect two elements in contact
    void OnTriggerEnter2D()
    {
        scoreObj.AddPoints(1);
        scoreSoundEffect.Play();
    }

    
}
