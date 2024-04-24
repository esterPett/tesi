using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookObject : MonoBehaviour
{
    [SerializeField] private Transform camera;
   
   
    void Update()
    {

        Vector3 LookVector = camera.position - transform.position; 
        Quaternion position = Quaternion.LookRotation(LookVector);

        transform.rotation =position; 
    
        
    }
}
