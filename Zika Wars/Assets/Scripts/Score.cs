using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int maxScore;
    public static int score;
    Text text;
    

    // Use this for initialization
    void Start () {
        score = 0;
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Pontos: " + score.ToString();

    }

    public void resetScore(){
        score = 0;
    }

    public void scoreUp(int points){
        score = score + points;
    }
}
