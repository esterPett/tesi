using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookObject : MonoBehaviour
{
    [SerializeField] private Transform camera;
   
   
    void Update()
    {

        Vector3 LookVector =  new Vector3(0,0,-1); 
        Quaternion position = Quaternion.LookRotation(LookVector);

        //transform.rotation = position;

        transform.LookAt(camera, LookVector);

    }
}
