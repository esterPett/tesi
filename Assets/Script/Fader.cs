using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField] float number;
    [SerializeField] [Range(0.02f,1f)] float smooth=0.02f;

   [SerializeField] Color black,trasparent,output;
   [SerializeField] Image image;

    public static Fader Instance {get; private set;}
    void Awake()
    {
        if(FindObjectsOfType<Fader>().Length>1)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance=this;
            DontDestroyOnLoad(gameObject);
        }

        


    }
    
    void UpdateOutputColor()
    {
        output=Color.Lerp(trasparent, black,number);
        image.color=output;
    }
 

    public IEnumerator ToBlack()
    {
        while (number<1)
        {
            number+=smooth;
            UpdateOutputColor();
            yield return new WaitForSeconds(smooth);

        }
        
        number=1;
        UpdateOutputColor();

    }
    public IEnumerator ToTrasparent()
    {
        while(number>0)
        {
            number-=smooth;
            UpdateOutputColor();
            yield return  new WaitForSeconds(smooth);
        }
        number=0;
        UpdateOutputColor();
    }
}
