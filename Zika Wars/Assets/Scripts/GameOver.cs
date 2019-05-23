using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    
    Score score;
    Text text;


    // Use this for initialization
    void Start()
    {
        
        text = GameObject.Find("Score").GetComponent<Text>();
        text.text = "Pontuação: " + Score.score.ToString();
        if(Score.score > Score.maxScore){
            Score.maxScore = Score.score;

        }
    }
    
    public void LoadLevel(string level){
        SceneManager.LoadScene(level);
    }


    public void Reload(){
        SceneManager.LoadScene("MainMenu");
    }


}
