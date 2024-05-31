using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator aniManager;

    void Start()
    {
        aniManager = GetComponent<Animator>();
    }
     public void changeIdle( bool isIdle)
    {
        aniManager.SetBool("IsIdle", isIdle);
         
        
    }
   
   
}
