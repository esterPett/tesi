using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator aniManager;
    [SerializeField] private AnimationClip transition;
    [SerializeField] private GameObject trueModel;
    [SerializeField] private GameObject animationModel;

    void Start()
    {
        aniManager = GetComponent<Animator>();
    }
     public void changeIdle( bool isIdle)
    {
        aniManager.SetBool("IsIdle", isIdle);     
    }
   
    public void startTransition ()
    {
        StartCoroutine(waitTransition());
    }
   
    private IEnumerator waitTransition ()
    {
        yield return new WaitForSeconds(transition.length);

        activeModel(true);
    }

    public void activeModel( bool active)
    {
        trueModel.SetActive(active);
        animationModel.SetActive(!active);
    }
}
