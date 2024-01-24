using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public Rigidbody rb;
    public float Score;
    public Text ScoreText;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            rb.velocity = new Vector3(0, 3  ,0);
        }
        if (this.transform.position.y <= -5)
        {
            SceneManager.LoadScene("GameOverScene");
        }
            

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
        if (other.gameObject.tag == "Points")
        {
            Score++;
            ScoreText.text = "Score :" + Score;
        }
    }
}
