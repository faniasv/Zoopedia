using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private int speed = 50;
    [SerializeField] Transform transform;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        transform = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }

}
