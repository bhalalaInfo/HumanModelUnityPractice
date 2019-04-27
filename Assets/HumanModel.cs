using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Examples.Demos;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HumanModel : MonoBehaviour, IMixedRealityTouchHandler
{
    // Start is called before the first frame update
    private Interactable routedTarget;

    [Header("Events")]
    public UnityEvent TouchBegin;
    public UnityEvent TouchEnd;
    public UnityEvent ButtonPressed;
    public UnityEvent ButtonReleased;

    public void OnTouchCompleted(HandTrackingInputEventData eventData)
    {
        ButtonReleased.Invoke();
    }

    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
        //ButtonPressed.Invoke();
    }

    public void OnTouchUpdated(HandTrackingInputEventData eventData)
    {
        //ButtonPressed.Invoke();
    }

    private void Awake()
    {
        routedTarget = GetComponent<Interactable>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void HandleButtonPressed()
    {
        Debug.Log("Button Pressed");
    }
   
}
