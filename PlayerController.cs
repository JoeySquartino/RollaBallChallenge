using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text scoreText;
    public Text winText;
    public Text livesText;

    private Rigidbody rb;
    private int count;
    private int score;
    private int lives;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        lives = 3;
        SetCountText ();
        winText.text = "";
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

    }

    void OnTriggerEnter(Collider other)

   
    {
        if (other.gameObject.CompareTag ("badpickup"))
        {
            other.gameObject.SetActive(false);
            lives = lives - 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag ("badpickup"))
        {
            other.gameObject.SetActive(false);
            count = count - 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            score = count + 1;
            SetCountText();
        }
    }

    void SetCountText ()

    {
        if (count == 13)
{
    transform.position = new Vector3(22f, 2.5f, 0.0f); 
}
        scoreText.text = "Count: " + score.ToString();
        livesText.text = "Lives: " + lives.ToString();
        if (lives == 0)
        {
            Destroy(this);
        }
        countText.text = "Score: " + count.ToString();
        if (count >= 21)
        {
            winText.text = "You Win!";
        }
    }
}