using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasparentScript : MonoBehaviour
{
    public IEnumerator Start()
    {

        yield return Fader.Instance.ToTrasparent();

    }

}
