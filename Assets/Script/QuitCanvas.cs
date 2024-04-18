using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitCanvas : MonoBehaviour
{
    [SerializeField] private GameObject canva;
  public void CanvasQuit()
  {
        canva.SetActive(false);

  }
  void Update()
  {
   if(Input.GetMouseButtonDown(0)) 
   {
    canva.SetActive(true);
   }
    
  }
}
