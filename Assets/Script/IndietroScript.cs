using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IndietroScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void IndietroGame()
    {
        StartCoroutine(start());
    }

    private IEnumerator start()
    {
        yield return Fader.Instance.ToBlack();

        yield return SceneManager.LoadSceneAsync(0);
    }
}
