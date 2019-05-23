using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour {
    
    GameObject mCanvas;
    Text targetText;

    void Start()
    {
        mCanvas = GameObject.FindGameObjectWithTag("Score");
        for (int i = 0; i < mCanvas.transform.childCount; i++)
        {
            GameObject child = mCanvas.transform.GetChild(i).gameObject;
            if (child.name == "whatever")
            {
                targetText = child.GetComponent<Text>();
            }
        }
    }

    // Update is called once per frame
    void Update(){
        //text.text = "Pontos: " + score.ToString();

    }
    
}
