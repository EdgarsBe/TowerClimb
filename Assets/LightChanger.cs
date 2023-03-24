using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public LightChecker Light;
    MeshRenderer rend;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.enabled = true;
        rend.material = Light.material[Light.x];
    }
}
