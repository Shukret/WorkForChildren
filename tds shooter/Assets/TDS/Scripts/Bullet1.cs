using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public GameObject explosion;
    
    
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject spawn = Instantiate(explosion,gameObject.transform.position,gameObject.transform.rotation);
        Destroy(spawn,5);
        Destroy(gameObject);

        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().lives -= 1;

        }

        if(other.tag == "enemy")
        {
            other.gameObject.GetComponent<Enemy>().lives -= 1;
        }
    }
    

    void Update()
    {
        
    }
}
