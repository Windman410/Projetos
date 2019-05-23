using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnerNumber : MonoBehaviour {
    GameObject[] spawners;
    Text text;
    int spawnersNumber;
	// Use this for initialization
	void Start () {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        text = gameObject.GetComponent<Text>();
        spawnersNumber = spawners.Length;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Focos: " + spawnersNumber.ToString();

    }

    public void removeSpawner(){
        spawnersNumber--;
    }
}
