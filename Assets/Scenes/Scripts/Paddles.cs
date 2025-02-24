using UnityEngine;
using UnityEngine.Audio;

public class Paddles : MonoBehaviour
{
    Rigidbody2D rigidBodyComponent;
    public bool isLeftPaddle;
    public bool isRightPaddle;
    public float torqueForce;

    public KeyCode actionKey;

    public AudioSource sound;

    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
       if (Input.GetKeyDown(actionKey))
       {
            sound.Play();
       }
       
      if (!isRightPaddle)
        {
            if (Input.GetKey(actionKey))
            {
                rigidBodyComponent.AddTorque(torqueForce, ForceMode2D.Impulse);
            }
            
            if (!Input.GetKey(actionKey))
            {
                rigidBodyComponent.AddTorque(-torqueForce);
            }
        }
        else if (isRightPaddle)
        {
            if (Input.GetKey(actionKey))
            {
                rigidBodyComponent.AddTorque(-torqueForce, ForceMode2D.Impulse);
            }
            
            if (!Input.GetKey(actionKey))
            {
                rigidBodyComponent.AddTorque(torqueForce);
            }
        }
    }
}
