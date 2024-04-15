using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public IEnumerator Start()
    {
       
        yield return Fader.Instance.ToTrasparent();
        
    }

    
}
