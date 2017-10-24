using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour
{

    // You can add listeners in inspector
    public UnityEvent OnSingleTap;
    public UnityEvent OnDoubleTap;


    float firstTapTime = 0f;
    float timeBetweenTaps = 0.2f; // time between taps to be resolved in double tap
    bool doubleTapInitialized;

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    void SingleTap()
    {
        doubleTapInitialized = false; // deinit double tap

        // fire OnSingleTap event for all eventual subscribers
        if (OnSingleTap != null)
        {
            
            OnSingleTap.Invoke();
        }
    }
    void DoubleTap()
    {
        doubleTapInitialized = false;
        if (OnDoubleTap != null)
        {
            OnDoubleTap.Invoke();
        }
    }


}
