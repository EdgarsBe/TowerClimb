using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActiveTeleportRay : MonoBehaviour
{
    public GameObject leftTeleport;
    public GameObject rightTeleport;

    public InputActionProperty leftActive;
    public InputActionProperty rightActive;

    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;

    // Update is called once per frame
    void Update()
    {
        leftTeleport.SetActive(leftCancel.action.ReadValue<float>() == 0 && leftActive.action.ReadValue<float>() > 0.1f);
        rightTeleport.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActive.action.ReadValue<float>() > 0.1f);
    }
}
