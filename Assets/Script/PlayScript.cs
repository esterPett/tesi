using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class PlayScript : MonoBehaviour
{

    public void PlayGame()
    {
        
       StartCoroutine(start());
    }

    private IEnumerator start()
    {   
        yield return Fader.Instance.ToBlack();

        yield return SceneManager.LoadSceneAsync(1);
    }

    
}
