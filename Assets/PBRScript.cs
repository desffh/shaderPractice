using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBRScript : MonoBehaviour
{
    public Renderer RD;

    public Material MT;

    private void Start()
    {
        MT.SetFloat("_Vector1", 1);
    }
}
