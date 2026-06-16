using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    //public GameObject obstacle;
    //Rigidbody2D rb;
    void Start()
    {
        //rb = obstacle.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
        //rb.transform.position += Vector3.MoveTowards(rb.tranform.position, pos, 0.1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            Debug.Log("Вы выиграли");
            Destroy(gameObject);
        }
    }
}
