using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveScript : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody2D rigidbody2D;
    //public Animator animator;
    public Text coinText;
    private int collected_coins;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
       // animator.SetFloat("FAST_SPEED", mov * speed);
        rigidbody2D.velocity = new Vector3(mov * speed, rigidbody2D.velocity.y, 0);
        if(Input.GetKey(KeyCode.Space))
        {
            rigidbody2D.velocity = new Vector3(mov * speed*5, rigidbody2D.velocity.y, 0);
           // rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x,speed*5, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.y, speed, 0);
        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            Debug.Log("coin addedd");
            collected_coins += 1;
            coinText.text = "Coins: " + collected_coins.ToString();
            GameObject.Destroy(collision.gameObject);
        }

        Debug.Log("coin addedd outside");

    }
}
