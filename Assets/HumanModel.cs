using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Examples.Demos;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanModel : MonoBehaviour, IMixedRealityTouchHandler
{
    // Start is called before the first frame update
    private Interactable routedTarget;

    public void OnTouchCompleted(HandTrackingInputEventData eventData)
    {
        Debug.Log("Touch Completed");
    }

    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
    }

    public void OnTouchUpdated(HandTrackingInputEventData eventData)
    {
    }

    private void Awake()
    {
        routedTarget = GetComponent<Interactable>();
    }
    void Start()
    {
        var physicalPressevnthndlr = GetComponent<PhysicalPressEventRouter>();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    
}
