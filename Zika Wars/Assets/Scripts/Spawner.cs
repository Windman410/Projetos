using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float positionXMin;
    public float positionXMax;
    public float positionYMin;
    public float positionYMax;
    public float cooldown;
    public bool activeSpawn;
    private float timeTillSpawn;
    private int enemyThisSpawner;
    public int maxEnemyThisSpawner;
    public GameObject[] enemyPrefabAll;
    private GameObject enemyPrefab;
    private GameObject[] enemiesOnScreen;
    public Sprite closedSprite;
    Transform playerPosition;
    SpawnerNumber objectiveUI;

    void Start () {
        playerPosition = (Transform)GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyPrefab = enemyPrefabAll[Random.Range(0,enemyPrefabAll.Length)]; // pega um inimigo aleatorio  
        activeSpawn = true;
        enemyThisSpawner = 0;
        maxEnemyThisSpawner = 5000;
        objectiveUI = FindObjectOfType<SpawnerNumber>();
    }

    // Update is called once per frame
    void Update () {
        timeTillSpawn -= Time.deltaTime;

        if (activeSpawn) {
            if (timeTillSpawn <= 0 && (Vector3.Distance(playerPosition.position, GetComponent<Transform>().position) < 10) ){
                enemiesOnScreen = GameObject.FindGameObjectsWithTag("Enemy");
                if (enemiesOnScreen.Length < 100 && enemyThisSpawner < maxEnemyThisSpawner){
                    SpawnEnemy();
                    enemyThisSpawner++;
                }
                else {
                    timeTillSpawn = cooldown;
                }
            }
        } 
        	
	}

    private void SpawnEnemy(){
        Vector2 newPos = new Vector2(Random.Range(this.transform.position.x + positionXMin, this.transform.position.x + positionXMax), Random.Range(this.transform.position.y + positionYMin, this.transform.position.y + positionYMax));
        GameObject octo = Instantiate(enemyPrefab,newPos,Quaternion.identity) as GameObject;
        timeTillSpawn = cooldown;

    }

    public void CloseSpawner(){
        activeSpawn = false;
        SpriteRenderer sp = (SpriteRenderer)GetComponent(typeof(SpriteRenderer));
        sp.sprite = closedSprite;
        objectiveUI.removeSpawner();
    }
}
