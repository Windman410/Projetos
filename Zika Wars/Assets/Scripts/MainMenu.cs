using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            SceneManager.LoadScene("Survival");

        }

    }

    public void Iniciar(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void Sair()
    {
        Application.Quit();
    }

}
