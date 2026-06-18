using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public GameObject bomb;
    public GameObject player;
    Rigidbody2D rb;
    float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(spawn), 1f, 1.5f);
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
            if (rb.transform.position.x < -10)
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
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            SceneManager.LoadScene(0);
        }
    }
    void spawn()
    {
        Vector3 pos = new Vector3(rb.transform.position.x + 2f, rb.transform.position.y+1f, -3);
        GameObject gunn = Instantiate(bomb, pos, Quaternion.identity);
        Destroy(gunn, 4);
    }
}
