using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Ball ball;
    

    public TMP_Text scoreTextDisplay;

    public TMP_Text livesText;

    public TMP_Text gameOver;

    public string gameOverMesage;

    void Start()
    {
        scoreTextDisplay.text = "Score: " + 0;

        livesText.text = "Lives: " + ball.lives.ToString();

        gameOver.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextDisplay.text = "Score: " + ball.score;

        livesText.text = "Lives: " + ball.lives.ToString();

        if (ball.lives > 0)
        {
            gameOver.text = " ";
        }
        else 
        {
            gameOver.text = gameOverMesage;
        }
    }
}
