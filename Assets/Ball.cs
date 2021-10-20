using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    //public GameObject point;
    public Rigidbody2D ball;
    //private Collision2D collision2;
    private float xeksen;
    private float yeksen;
    private float xeksen2;
    private float yeksen2;
    private float yon;
    //private float xeksenp;
    //private float yeksenp;
    private float speed = 4f;
    //public GameObject player;
    void Start()
    {
        //StartCoroutine(Slow());
        //xeksenp = point.transform.position.x - ball.position.x;
        //yeksenp = point.transform.position.y - ball.position.y;
    }
    void Update()
    {
        xeksen = player.transform.position.x - ball.position.x;
        yeksen = player.transform.position.y - ball.position.y;
        xeksen2 = player2.transform.position.x - ball.position.x;
        yeksen2 = player2.transform.position.y - ball.position.y;
        //if (collision2.gameObject.tag != "Player")
        //{

        //}
    }
    IEnumerator Slow()
    {
        yield return new WaitForSeconds(1f);
        //if (speed <= 0)
        //{

        //}
        //else
        //{
        //    speed--; 
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetButton("Jump"))
        {
            vurma();
        }
        if (collision.gameObject.tag == "Player2" && Input.GetButton("Jump1"))
        {
            vurma2();
        }
        if (collision.gameObject.tag == "Wall")
        {
            yon = 1f;
            wall();
        }
        if (collision.gameObject.tag == "WallUpDown")
        {
            yon = 1f;
            wall2();
        }
        if (collision.gameObject.tag == "WallRight")
        {
            yon = -1f;
            wall();
        }
        if (collision.gameObject.tag == "WallDown")
        {
            yon = -1f;
            wall2();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetButton("Jump"))
        {
            vurma();
        }
        if (collision.gameObject.tag == "Player2" && Input.GetButton("Jump1"))
        {
            vurma2();
        }
        if (collision.gameObject.tag == "Wall")
        {
            yon = 1f;
            wall();
        }
        if (collision.gameObject.tag == "WallUpDown")
        {
            yon = 1f;
            wall2();
        }
        if (collision.gameObject.tag == "WallRight")
        {
            yon = -1f;
            wall();
        }
        if (collision.gameObject.tag == "WallDown")
        {
            yon = -1f;
            wall2();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetButton("Jump"))
        {
            vurma();
        }
        if (collision.gameObject.tag == "Player2" && Input.GetButton("Jump1")) 
        {
            vurma2();
        }
        if (collision.gameObject.tag == "Wall")
        {
            yon = 1f;
            wall();
        }
        if (collision.gameObject.tag == "WallUpDown")
        {
            yon = 1f;
            wall2();
        }
        if (collision.gameObject.tag == "WallRight")
        {
            yon = -1f;
            wall();
        }
        if (collision.gameObject.tag == "WallDown")
        {
            yon = -1f;
            wall2();
        }
    }
    private void vurma()
    {
        float xComponent = -xeksen * speed;
        float yComponent = -yeksen * speed;
        Vector3 forceApplied = new Vector3(xComponent, yComponent, 0);
        ball.AddForce(forceApplied, ForceMode2D.Impulse);
    }
    private void vurma2()
    {
        float xComponent = -xeksen2 * speed;
        float yComponent = -yeksen2 * speed;
        Vector3 forceApplied = new Vector3(xComponent, yComponent, 0);
        ball.AddForce(forceApplied, ForceMode2D.Impulse);
    }
    private void wall()
    {
        float xComponent = yon * 2f;
        float yComponent = 0;//yeksenp/ Mathf.Abs(yeksen) * 2f;
        Vector3 forceApplied = new Vector3(xComponent, yComponent, 0);
        ball.AddForce(forceApplied, ForceMode2D.Impulse);
    }
    private void wall2()
    {
        float xComponent = 0; //xeksenp / Mathf.Abs(xeksen) * speed;
        float yComponent = yon * 2f;
        Vector3 forceApplied = new Vector3(xComponent, yComponent, 0);
        ball.AddForce(forceApplied, ForceMode2D.Impulse);
    }
}
