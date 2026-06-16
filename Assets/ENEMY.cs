using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    Rigidbody2D rb;
    Rigidbody2D rbb;
    // Start is called before the first frame update
    void Start()
    {
        rb = enemy.GetComponent<Rigidbody2D>();
        rbb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = Vector3.MoveTowards(rb.transform.position, rbb.transform.position, 3.5f* Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Вы проиграли");
            Destroy(collision.gameObject);
        }
    }
}
