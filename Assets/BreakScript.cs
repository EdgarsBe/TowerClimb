using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakScript : MonoBehaviour
{

    public Rigidbody Rigidbodyrb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Rigidbodyrb.isKinematic = false;
            Rigidbodyrb.useGravity = true;
        }
    }
}
