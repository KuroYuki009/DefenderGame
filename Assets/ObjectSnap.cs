using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSnap : MonoBehaviour
{
    public Vector3 snapPoint;
    public Quaternion snapQuat;
    void Start()
    {
        snapPoint = gameObject.transform.position;
        snapQuat = gameObject.transform.rotation;
    }
}
