using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class QuitScript : MonoBehaviour
{
  
  public IEnumerator Start()
    {
       
        yield return Fader.Instance.ToTrasparent();

        yield return new WaitForSeconds(2);
        
        Application.Quit();

        #if UNITY_EDITOR
        EditorApplication.isPlaying=false;
        #endif


        
    }

}
