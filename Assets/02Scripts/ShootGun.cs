using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ShootGun : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;
    public float speed = 20;
    private void Start()
    {
        XRGrabInteractable grab = GetComponent<XRGrabInteractable>();
        grab.activated.AddListener(fire);
    }

    private void Update()
    {
        
    }

    public void fire(ActivateEventArgs args)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnpoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnpoint.forward * speed;
        Destroy(spawnedBullet,5);
    }

}
