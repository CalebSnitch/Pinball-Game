using UnityEngine;
using UnityEngine.Audio;

public class Triangle : MonoBehaviour
{
    
    public Ball ball;

    public float scoreValue;

    public AudioSource ding;


    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ball.score += scoreValue;

        ding.Play();
    }


    void Update()
    {
        
    }
}
