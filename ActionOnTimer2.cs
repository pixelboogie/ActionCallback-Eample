using System; // need to use system
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActionOnTimer2 : MonoBehaviour
{
    /// add 
    private Action timerCallback;

    private float timer;

    public void SetTimer(float timer, Action timerCallback) // add 
    {
        this.timer = timer;
        this.timerCallback = timerCallback; // add
    }

    private void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            // add check if complete
            if (IsTimerComplete())
            {
                timerCallback(); // call the timerCallback function
            }
        }

    }

    public bool IsTimerComplete()
    {
        return timer <= 0f;
    }


}
