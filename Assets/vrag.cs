using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vrag : MonoBehaviour
{
    Rigidbody2D rb; 
    Rigidbody2D rbb;
    int hit = 3;
    public GameObject player;
    public GameObject enemy;
    public GameObject bomb;
    AudioSource udar;
    public Vector3 juj = new Vector3(Random.Range(3f, 8.32f), Random.Range(-4.18f, 4.17f), -3);
    AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        rbb = enemy.GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(bullet), 1f, 2f);
        udar = player.GetComponent<AudioSource>();
        sound = enemy.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rbb.transform.position = Vector3.MoveTowards(rbb.transform.position, juj, 10f * Time.deltaTime);
    }
    void bullet()
    {
        juj = new Vector3(Random.Range(3f, 8.32f),Random.Range(-4.17f, 4.18f), -3);
        Vector3 pos = new Vector3(rbb.transform.position.x-2f, rbb.transform.position.y, -2);
        GameObject gunn = Instantiate(bomb, pos, Quaternion.identity);
        Destroy(gunn, 4f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            --hit;
            if(hit == 0)
            {
                sound.Play();
                Destroy(enemy);
            }
        }
    }
}
