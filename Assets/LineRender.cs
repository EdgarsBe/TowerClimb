using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{
    public GameObject[] obj;
    private LineRenderer lineRenderer;
    
    void Start()
    {
        lineRenderer = this.gameObject.GetComponent<LineRenderer>();
    }

    void Update()
    {
        for (int i = 0; i < obj.Length; i++)
        {
            lineRenderer.SetPosition(i, obj[i].transform.position);
        }
    }
}
