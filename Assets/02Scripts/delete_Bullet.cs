using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
       {
           if (other.gameObject.CompareTag("Bullet")) {
               // Destroy the enemy object.
               Destroy(other.gameObject);
           }
       }
}
