using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(avvio());
    }

    private IEnumerator avvio()
    {
        yield return Fader.Instance.ToBlack();

        yield return SceneManager.LoadSceneAsync(0);
    }
}
