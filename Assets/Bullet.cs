using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject bullet;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = bullet.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = Vector3.left * 2f * Time.deltaTime;
    }
}
