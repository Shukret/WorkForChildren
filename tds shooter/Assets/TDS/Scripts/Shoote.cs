using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoote : MonoBehaviour
{
    public Transform spawn;
    public GameObject bulletprefab;
    public float speed = 20;











    
    void Start()
    {
        
    }

    public void Shoot()
    {
        GameObject Bullet = Instantiate(bulletprefab,spawn.position,spawn.rotation);

        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();

        rb.AddForce(spawn.up * speed,ForceMode2D.Impulse);
    }




    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

       

    }
}
