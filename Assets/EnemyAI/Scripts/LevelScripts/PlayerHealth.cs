using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : HealthManager
{
    public float health = 100f;

    public string scene;
    
    
    public override void TakeDamage(Vector3 location, Vector3 direction, float damage, Collider bodyPart = null, GameObject origin = null)
    {
        health -= damage;

        if (health < 0)
        {
            dead = true;
            health = 0;
            Debug.Log("dead");

            SceneManager.LoadScene(scene);
        }
        else
        {
            
            Debug.Log(health);
            
        }
    }
}

