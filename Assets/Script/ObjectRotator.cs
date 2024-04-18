using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
  
    [SerializeField]  private Transform[] objects;
    [SerializeField]  private float speed= 30;

    [SerializeField]  private float mouseSpeedX = 0.0f;

    [SerializeField] private float mouseSpeedY = 0.0f;
    void Update()
    {
        mouseSpeedX = Input.GetAxis("Mouse X");
        mouseSpeedY = Input.GetAxis("Mouse Y");

        mouseSpeedX = Mathf.Clamp(mouseSpeedX,-1,1);
        mouseSpeedY = Mathf.Clamp(mouseSpeedY,-1,1);

        foreach(Transform item in objects)
        {
            Debug.Log(item.gameObject.name);
            
            item.Rotate(speed*Time.deltaTime*mouseSpeedY,speed*Time.deltaTime*mouseSpeedX,0,Space.Self);
        }

    }
}
