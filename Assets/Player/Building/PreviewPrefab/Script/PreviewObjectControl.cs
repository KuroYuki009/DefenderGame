using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewObjectControl : MonoBehaviour
{
    //��ɒl�p
    // bool obstacleColliSW;

    void Start()
    {
         
    }


    private void OnTriggerStay(Collider other)
    {
        ObstacleCollision();
    }


    void ObstacleCollision()
    {

    }
}
