using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    public InputActionProperty PinchAnimation;
    public InputActionProperty GrabnAnimation;

    public Animator HandAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pinchValue = PinchAnimation.action.ReadValue<float>();
        HandAnimator.SetFloat("Pinch", pinchValue);

        float grabValue = GrabnAnimation.action.ReadValue<float>();
        HandAnimator.SetFloat("Grab", grabValue);
    }
    // Made my Simon Axelsen
}
