using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooteEnemy : MonoBehaviour
{
    public Transform spawn;
    public GameObject bulletprefab;
    public float speed = 20;
    public float time = 3;



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
        time -= Time.deltaTime;

        if(time <= 0 && gameObject.GetComponent<Enemy>().angry == true)
        {
            Shoot();

            time = 3;
        }
    }
}
