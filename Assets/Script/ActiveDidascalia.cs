using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDidascalia : MonoBehaviour
{
     private GameObject didascalia;
    [SerializeField] private GameObject button; 
    public void Active ()
    {
        
        didascalia.SetActive(!didascalia.activeInHierarchy);
    }

    public void ViewButton(bool selezione)
    {
        button.SetActive(selezione);
    }

    public void SetDidascalia(GameObject info)
    {
        didascalia = info; 
    }
}
