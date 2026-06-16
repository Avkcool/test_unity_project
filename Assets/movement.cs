using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb;
    float speed = 7f;
    int guns = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.position += Vector3.up * speed * Time.deltaTime;
            if (rb.transform.position.y > 3)
            {
                Vector3 vector = new Vector3(rb.transform.position.x, 3, -2);
                rb.transform.SetPositionAndRotation(vector, Quaternion.identity);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position += Vector3.left * speed * Time.deltaTime;
            if (rb.transform.position.x <-10)
            {
                Vector3 vector = new Vector3(-10, rb.transform.position.y, -2);
                rb.transform.SetPositionAndRotation(vector, Quaternion.identity);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position += Vector3.down * speed * Time.deltaTime;
            if (rb.transform.position.y < -4)
            {
                
                Vector3 vector = new Vector3(rb.transform.position.x, -4, -2);
                rb.transform.SetPositionAndRotation(vector, Quaternion.identity);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position += Vector3.right * speed * Time.deltaTime;
            if (rb.transform.position.x > 10)
            {
                Vector3 vector = new Vector3(10, rb.transform.position.y, -2);
                rb.transform.SetPositionAndRotation(vector, Quaternion.identity);
            }
        }
        if(guns == 10)
        {
            Debug.Log("Бегите домой");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            guns += 1;
            speed -= 0.1f;
            Destroy(collision.gameObject);
            Debug.Log(guns);
        }else if (collision.CompareTag("Finish"))
        {
            if (guns == 10)
            {
                Destroy(player);
            }
        }else if (collision.CompareTag("Feet"))
        {
            Destroy(player);
            Destroy(collision.gameObject);
            Debug.Log("Вы взорвались");
        }
    }
}
