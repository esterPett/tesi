using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        
        yield return Fader.Instance.ToBlack();

        yield return SceneManager.LoadSceneAsync(1);
    }

  
}
