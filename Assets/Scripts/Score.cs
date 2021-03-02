using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    [SerializeField] Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
        //Imprime el score al principio
        scoreText.text = "Score: " + score.ToString();
        print(score); 
    }

    private void HandleScore ()
    {
        //Se cmabia el texto con el score actual
        scoreText.text = "Score: " + score.ToString();
        print(score); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Neceitamos una manera de diferenciar la colisión que genera puntos (la meta)
        if (col.gameObject.tag == "Meta")
        {
            score++;
            HandleScore ();
        } else {
            score--;
            HandleScore();
        }
    }

}
