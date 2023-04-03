using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionerEnter2D(Collision2D col){
        Destroy(col.gameObject);
    }
}
