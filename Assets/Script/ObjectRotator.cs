using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
  
    [SerializeField]  private Transform[] objects;
    [SerializeField]  private float speed= 30;

    [SerializeField]  private float mouseSpeed = 0.0f;
    void Update()
    {
        mouseSpeed = Input.GetAxis("Mouse X");

        mouseSpeed= Mathf.Clamp(mouseSpeed,-1,1);

        foreach(Transform item in objects)
        {
            Debug.Log(item.gameObject.name);
            
            item.Rotate(0,speed*Time.deltaTime*mouseSpeed,0,Space.Self);
        }

    }
}
