using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookObject : MonoBehaviour
{
    [SerializeField] private Transform camera;
    
   
    void Update()
    {

        transform.LookAt(new Vector3(camera.position.x, 0, camera.position.z));

    }
}
