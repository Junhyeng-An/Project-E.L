using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hit_Bullet : MonoBehaviour
{


    
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet")) {
            // Destroy the enemy object.
            Destroy(other.gameObject);

            // Destroy the bullet object.
            this.GameObject().SetActive(false);
        }
    }
}
