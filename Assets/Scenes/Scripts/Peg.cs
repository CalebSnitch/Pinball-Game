using UnityEngine;
using UnityEngine.Audio;

public class Peg : MonoBehaviour
{
    public Ball ball;


   public float scoreValue;

    public AudioSource ding;

    void Start()
    {
        
    }

    void OnCollisionEnter2D()
    {
        ball.score += scoreValue;

        //Debug.Log("happened");

        ding.Play();
    }
    void Update()
    {
        
    }
}
