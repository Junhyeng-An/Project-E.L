using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    Rigidbody rigid;
    
    public enum EnemyType
    {
        Gun,
        Knife,
        stand
    }
    public EnemyType inputType;

    void Start()
    {
        
    }
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        float speed = 0.5f;
        float range = 10f;
        float distance = Vector3.Distance(transform.position, playerPos);
        if (distance <= range)
        {
            transform.LookAt(player.transform);

            transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
        }

        if (inputType == EnemyType.Knife)
        {
            
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.layer);
        if(col.gameObject.layer == 14)
        {
            Destroy(this.gameObject);
        }
    }
}