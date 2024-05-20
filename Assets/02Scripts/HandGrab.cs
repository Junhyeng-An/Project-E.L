using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HandGrab : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < 0.5f)
        {
            Debug.Log("111");
            if (Input.GetKey(KeyCode.F))
            {
                target.transform.position = transform.position;
                target.transform.rotation = transform.rotation;
            }
        }
    }
}
