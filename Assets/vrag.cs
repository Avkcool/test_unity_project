using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour
{
    Rigidbody2D rb; 
    Rigidbody2D rbb;
    GameObject player;
    GameObject enemy;
    GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        rbb = enemy.GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(bullet), 1f, 2f);
        InvokeRepeating(nameof(move), 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void bullet()
    {
        Vector3 pos = new Vector3(rbb.transform.position.x, rbb.transform.position.y, -3);
        GameObject gunn = Instantiate(bomb, pos, Quaternion.identity);
        Destroy(gunn, 4f);
    }
    void move()
    {
        Vector3 vector = new Vector3(rbb.transform.position.y + Random.Range(-3, 3), rbb.transform.position.x + Random.Range(-3, 3), -3);
        rbb.transform.position = vector;
    }
}
