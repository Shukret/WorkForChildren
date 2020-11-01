using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        
    }

    
    void Update()
    {
        gameObject.transform.position = new Vector3(player.position.x,player.position.y,gameObject.transform.position.z);
    }
}
