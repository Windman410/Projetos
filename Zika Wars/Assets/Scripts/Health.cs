using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public int health;
    Text text;

    // Use this for initialization
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = "Vidas: " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Vidas: " + health.ToString();

    }

    public void healthDown(){
        health--;
    }

}
