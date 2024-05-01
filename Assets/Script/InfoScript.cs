using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{
    [SerializeField] private GameObject caption;
    /*void Start()
    {
        caption.SetActive(false);
    }*/

    public void OnShowCaption()
    {
        caption.SetActive(true);
    }
}
