using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMove : MonoBehaviour
{

    public float velocity = 1;
    private Rigidbody2D rb;
    public ManageGame ManageGame;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "pipe")
        {
            ManageGame.GameOver();
        }
        else if (collision.collider.tag == "medal") {
            ManageGame.Win();
        }

        //else

        //if (collision.collider.tag == "winner")
        //{

        //    ManageGame.Win();
        //}
        //else

        //if (collision.collider.tag == "easy")
        //{

        //    ManageGame.WinFree();
        //}
    }

}

