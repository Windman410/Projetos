using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour {

    GameObject[] tutorialControle;
    GameObject[] tutorialObjetivo;
    GameObject[] tutorialAcao;
    GameObject[] controlObjects;
    GameObject[] UIObjects;
    int flag;
    // Use this for initialization
    void Start () {
        Time.timeScale = 0;
        flag = 0;
        tutorialControle = GameObject.FindGameObjectsWithTag("TutorialControle");
        tutorialAcao = GameObject.FindGameObjectsWithTag("TutorialAcao");
        tutorialObjetivo = GameObject.FindGameObjectsWithTag("TutorialObjetivo");
        controlObjects = GameObject.FindGameObjectsWithTag("GameController");
        UIObjects = GameObject.FindGameObjectsWithTag("UserInterfaceTop");
        hideAcao();
        hideObjetivo();
    }

    // Update is called once per frame
    void Update () {
	}

    public void tutorial(){
        if(flag == 0){
            hideControle();
            hideUI();
            showAcao();
            flag++;
        }
        else if (flag == 1)
        {
            hideAcao();
            showObjetivo();
            flag++;
        }
        else if (flag == 2)
        {
            SceneManager.LoadScene("MainMenu");  
        }
    }

    public void hideAcao()
    {
        foreach (GameObject g in tutorialAcao)
        {
            g.SetActive(false);
        }
    }
    public void hideObjetivo()
    {
        foreach (GameObject g in tutorialObjetivo)
        {
            g.SetActive(false);
        }
    }

    public void hideControle()
    {
        foreach (GameObject g in tutorialControle)
        {
            g.SetActive(false);
        }
    }

    public void showControle()
    {
        foreach (GameObject g in tutorialControle)
        {
            g.SetActive(true);
        }
    }

    public void showObjetivo()
    {
        foreach (GameObject g in tutorialObjetivo)
        {
            g.SetActive(true);
        }
    }

    public void showAcao()
    {
        foreach (GameObject g in tutorialAcao)
        {
            g.SetActive(true);
        }
    }

    public void hideUI()
    {
        foreach (GameObject g in controlObjects)
        {
            g.SetActive(false);
        }

        foreach (GameObject g in UIObjects)
        {
            g.SetActive(false);
        }
    }


}
