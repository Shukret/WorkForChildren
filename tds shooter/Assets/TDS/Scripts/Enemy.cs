using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int lives;
    public float speed;
    public Transform player;
    public bool angry;

    void Start()
    {
        
    }

    
    void Update()
    {


        if(lives <= 0)
        {
            Destroy(gameObject);
        }

        if(angry)
        {
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position,player.position,speed * Time.deltaTime);
                
            gameObject.transform.up = player.position - gameObject.transform.position;
        } 

        
    }

}
