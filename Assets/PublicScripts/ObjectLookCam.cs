using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLookCam : MonoBehaviour
{
    public Transform target;

   
    void Update()
    {
        transform.LookAt(target);

        transform.LookAt(target, Vector3.right);
    }
}
