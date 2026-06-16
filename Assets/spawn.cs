using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gun;
    public GameObject bomb;
    void Start()
    {
        rb = gun.GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(Spawn), 1f, 2.5f);
        InvokeRepeating(nameof(Spawn), 1f, 2.5f);
        InvokeRepeating(nameof(Spawn), 1f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        int a = Random.Range(1, 11);
        if(a == 10)
        {
            Bomb();
            return;
        }
        Vector3 pos = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0);
        GameObject gunn = Instantiate(gun, pos,Quaternion.identity);
        Destroy(gunn, 5f);
    }
    void Bomb()
    {
        Vector3 pos = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0);
        GameObject gunn = Instantiate(bomb, pos, Quaternion.identity);
        Destroy(gunn, 5f);
    }
}
