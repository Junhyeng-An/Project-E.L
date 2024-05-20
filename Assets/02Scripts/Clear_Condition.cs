using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear_Condition : MonoBehaviour
{
    
   
    public string enemyTag = "Enemy"; // Tag of the enemy game objects
    public string nextScene = "NextScene"; // Name of the next scene to load

    private void Update()
    {
        if (AreAllEnemiesDead())
        {
            ChangeScene();
        }
    }

    private bool AreAllEnemiesDead()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        foreach (GameObject enemy in enemies)
        {
            if (enemy != null && enemy.activeInHierarchy)
            {
                // At least one enemy is still alive, return false
                return false;
            }
        }

        // All enemies are dead, return true
        return true;
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}