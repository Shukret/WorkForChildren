using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lives;
    public float speed;
    public Rigidbody2D rb;
    public Camera ca;
    public Vector2 mousepos;
    public Vector2 movement;
    


    void Start()
    {
        lives = 5;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "triggerzone")
        {
            other.gameObject.transform.parent.GetComponent<Enemy>().angry = true;
        }
    }
        
    public void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        Vector2 lugdir = mousepos - rb.position;

        float angle = Mathf.Atan2(lugdir.y,lugdir.x) * Mathf.Rad2Deg - 90;

        rb.rotation = angle;
    }
    
    void Update()
    {

        mousepos = ca.ScreenToWorldPoint(Input.mousePosition);

        if(lives <= 0)
        {
            Time.timeScale = 0;
        }

    }
}
