using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabbableObject : XRBaseInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {

        if (args.interactorObject is XRDirectInteractor)
        {
            Climber.climbingHand = args.interactorObject.transform.GetComponent<ActionBasedController>();
        }

        base.OnSelectEntered(args);
    }


    protected override void OnSelectExited(SelectExitEventArgs args)
    {

        if (Climber.climbingHand && Climber.climbingHand.name == args.interactorObject.transform.name)
        {
            Climber.climbingHand = null;
        }
        base.OnSelectExited(args);
    }
}
