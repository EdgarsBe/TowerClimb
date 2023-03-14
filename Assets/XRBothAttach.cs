using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRBothAttach : XRGrabInteractable
{

    public Transform leftAttach;
    public Transform rightAttach;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = leftAttach;
        }
        if (args.interactorObject.transform.CompareTag("RightHand"))
        {
            attachTransform = rightAttach;
        }

        base.OnSelectEntered(args);
    }
}
