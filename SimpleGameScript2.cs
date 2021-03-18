using System; // need to use system
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGameScript2 : MonoBehaviour
{
    
    // much cleaner approach
    // simply call SetTimer and add the 2nd parameter
    [SerializeField] private ActionOnTimer2 actionOnTimer2;

    private void Start()
    {
       actionOnTimer2.SetTimer(1f, () => { Debug.Log("Timer complete!"); });// add the timer callback in form of lambda
    }

}
