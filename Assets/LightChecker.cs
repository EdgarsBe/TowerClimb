using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChecker : MonoBehaviour
{

    public Material[] material;
    public int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lamp"))
        {
            x = 1;
        }
        if (other.CompareTag("UnLamp"))
        {
            x = 2;
        }
    }  
    private void OnTriggerExit(Collider other)
    {
        x = 0;
    }
}
