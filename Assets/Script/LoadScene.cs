using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Scene(int index)

    {
        StartCoroutine(Load( index));
    }
    
    private IEnumerator Load(int index)
    {
       yield return Fader.Instance.ToBlack();
        SceneManager.LoadScene(index);
    }
}
