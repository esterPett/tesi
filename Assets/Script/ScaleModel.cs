using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleModel : MonoBehaviour
{
    [SerializeField] private Transform[] models;
    

    void Update()
    {
       
        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            if (touch0.phase == TouchPhase.Moved && touch1.phase == TouchPhase.Moved)
            {
                float prevTouchDeltaMag = (touch0.position - touch0.deltaPosition - (touch1.position - touch1.deltaPosition)).magnitude;

                float touchDeltaMag = (touch0.position - touch1.position).magnitude;

                float deltaMagnitudeDiff = touchDeltaMag - prevTouchDeltaMag;

                Scale(deltaMagnitudeDiff);
            }
        }
    }

    void Scale(float deltaMagnitudeDiff)
    {
        if ( models.Length == 0)
            return;

        foreach (Transform item in models)
        {
            if (item == null)
                continue;

            Vector3 newScale = item.localScale;

            
            newScale *= (1f - deltaMagnitudeDiff * 0.01f); 

            
            float minScale = 0.1f;
            float maxScale = 3f;
            newScale = Vector3.Max(newScale, Vector3.one * minScale);
            newScale = Vector3.Min(newScale, Vector3.one * maxScale);

            
            item.localScale = newScale;
        }
    }





}
