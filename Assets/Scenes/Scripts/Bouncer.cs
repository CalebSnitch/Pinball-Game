using UnityEngine;
using UnityEngine.Audio;

public class Bouncer : MonoBehaviour
{

    private Vector3 startingScale;

    public Vector3 contractedScale;

    public float contractionTime;

    private float timer;

    private bool contracted = false;

    public Ball ball;

    public float scoreValue;

    public AudioSource ding;
 
    void Start()
    {
        startingScale = this.transform.localScale;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (contracted == false)
        {
            this.transform.localScale = contractedScale;

            timer = 0;

            contracted = true;

            ball.score += scoreValue;

            ding.Play();

        }
    }

    void Update()
    {
        if (contracted == true)
        {
            timer += 1 * Time.deltaTime;

            if (timer >= contractionTime)
            {
               this.transform.localScale = startingScale;

                contracted = false;
            }
        }

    }
}
