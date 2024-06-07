using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookObject : MonoBehaviour
{
    [SerializeField] private Transform camera;
    [SerializeField] private int lookZ;
   
    void Update()
    {

        Vector3 LookVector =  new Vector3(0,0, lookZ); 
         transform.LookAt(new Vector3 (0,0,camera.position.z), LookVector);

    }
}
