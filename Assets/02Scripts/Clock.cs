using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
public class Clock : MonoBehaviour
{
    public GameObject h;
    public GameObject m;
    public GameObject s;

    float second;
    float minute;
    float hour;
    void Update()
    {
        second = DateTime.Now.Second;
        minute = DateTime.Now.Minute;
        hour = DateTime.Now.Hour;

        h.transform.rotation = Quaternion.Euler(hour * 30 + minute / 2, 0, 0);
        m.transform.rotation = Quaternion.Euler(minute * 6, 0, 0);
        s.transform.rotation = Quaternion.Euler(second * 6, 0, 0);
    }
}
