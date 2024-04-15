using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IndietroScript2 : MonoBehaviour
{
    
    public void IndietroGame2()
    {
        StartCoroutine(start());
    }
   
    
    private IEnumerator start()
    {
        yield return Fader.Instance.ToBlack();

        yield return SceneManager.LoadSceneAsync(2);

    }
}
