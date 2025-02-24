using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float score = 0;

    public int lives = 3;

    private Vector3 startingLocation;

    //private bool active = false;

    private bool canLoseLives = true;

    public Vector3 startForce;

    private Rigidbody2D rb;


    void Start()
    {
        startingLocation = transform.position;

        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
       /*
       if (active == false)
       {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                active = true;

                this.rb.AddForceAtPosition(startForce, this.transform.position, ForceMode2D.Impulse);

            }
       }

       */

       if (transform.position.y < -15 && canLoseLives == true)
       {
            lives -= 1;

            

            if (lives > 0)
            {
                this.transform.position = startingLocation;
                //active = false;
            }
            else 
            {
                canLoseLives = false;
            }
            
            

           
       }

       if (Input.GetKeyDown(KeyCode.Space) && transform.position.y > -9.5 && transform.position.y < -4.5
                && transform.position.x > 7.5 && transform.position.x < 10.12)
             {
                  this.rb.AddForceAtPosition(startForce, this.transform.position, ForceMode2D.Impulse);
             }

       
        if (Input.GetKeyDown(KeyCode.Q) && lives <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

       
       
       
       
       
       //Debug.Log(score);
    }
}
