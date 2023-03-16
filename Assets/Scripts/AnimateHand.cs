using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{

    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripdAnimationAction;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        anim.SetFloat("Trigger", triggerValue);
        float gripValue = gripdAnimationAction.action.ReadValue<float>();
        anim.SetFloat("Grip", gripValue);
    }
}
