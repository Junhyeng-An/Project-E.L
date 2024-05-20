using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EffectReticle : MonoBehaviour
{
    float x = 0;
    void Update()
    {
        transform.Rotate(0, 0.5f, 0, Space.World);  //rotate

        x += 0.02f; 
        transform.localScale = Vector3.one * (Mathf.Sin(x)/5 + 1);  //scale up & down
    }
}