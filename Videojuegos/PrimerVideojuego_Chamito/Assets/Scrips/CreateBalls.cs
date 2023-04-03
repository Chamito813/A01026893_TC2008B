using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    //Class variable to be changed from the Unity interface
    [SerializeField] GameObject ball;
    [SerializeField] float delay;

    // Start is called before the first frame update
    void Start()
    {
        // CALL the "DropBall" function after 0.5 seconds
        // and then keep calling it every 0.8 seconds.
        InvokeRepeating("DropBall", 0.5f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropBall()
    {
        // Generate a new random position
        Vector3 pos = new Vector3(Random.Range(-4.0f, 4.0f), transform.position.y);
        // Create a copy of the prefab
        GameObject obj = Instantiate(ball, pos, Quaternion.identity);
        //Destroy(obj, 5);
    }

    public void StopBalls(){
        CancelInvoke("DropBall");
    }
}
