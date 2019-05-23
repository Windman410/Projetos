using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    GameObject[] pauseObjects;
    GameObject[] controlObjects;
    Scene currentScene;


    // Use this for initialization
    void Start(){
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        controlObjects = GameObject.FindGameObjectsWithTag("GameController");
        currentScene = SceneManager.GetActiveScene();
        hidePaused();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetButtonDown("Pause"))
        {
            Debug.Log("Pause");
            pauseControl();
        }

        if (Input.GetButtonDown("Select"))
        {
            Debug.Log("Select");
            SceneManager.LoadScene(currentScene.buildIndex);
        }
        //uses the p button to pause and unpause the game

    }

    public void Pause() {
        Time.timeScale = 0;
        showPaused();
    }

    public void Unpause() {
        Debug.Log("high");
        Time.timeScale = 1;
        hidePaused();        
    }
    
    public void Reload()
    {
        SceneManager.LoadScene(currentScene.buildIndex); 
    }

    //controls the pausing of the scene
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }

        foreach (GameObject g in controlObjects)
        {
            g.SetActive(false);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }

        foreach (GameObject g in controlObjects)
        {
            g.SetActive(true);
        }
    }

    //loads inputted level
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
