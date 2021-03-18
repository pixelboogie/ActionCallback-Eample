using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGameScript : MonoBehaviour
{
    
    // this is an extremely dirty approach
    // instead of the timer being conrolled by the timer class
    // the implementation is split into different places
    // if we need to use timer somewhere else, we need to reimplement this again
    // both classes are tightly coupled, not good

    [SerializeField] private ActionOnTimer actionOnTimer;
    private bool hasTimerElapsed; // keeping a boolean to know if elapsed or not

    void Start()
    {
        actionOnTimer.SetTimer(1f);
    }

    // checking every update if timer has elapsed
    private void Update()
    {
        if(!hasTimerElapsed && actionOnTimer.IsTimerComplete())
        {
            Debug.Log("Timer complete!");
            hasTimerElapsed = true;
        }
    }
}
