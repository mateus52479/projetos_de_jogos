using System;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class Player : MonoBehaviour
{
    public Animator anim;
    public float speed;
    private Rigidbody2D rigid;

    public float jump_force = 7f;
    private bool isground = true;
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        jump();
    }

    void Move()
    {
        float teclas = Input.GetAxis("Horizontal");
        rigid.linearVelocity = new Vector2(teclas * speed, rigid.linearVelocity.y);

        if (teclas > 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 0);
            anim.SetInteger("transition", 1);
        }

        if (teclas < 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 180);
            anim.SetInteger("transition", 1);
        }

        if (teclas == 0 && isground == true)
        {
            anim.SetInteger("transition", 0);
        }
    }
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isground == true)
        {
            rigid.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
            anim.SetInteger("transition", 2);
            isground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tag_ground")
        {
            isground = true;
            anim.SetInteger("transition", 0);
            Debug.Log("está no chao");
        }
    }

}
