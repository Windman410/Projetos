using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    private Player player;
    public Transform start;
    public GameObject enemy;
    public GameObject score;
    int health = 1;


    void Start() {
        player = FindObjectOfType<Player>();
    }

    void Update() {

    }
    
    void takeDamage(int damage) {
        health = health - damage;

        if (health <= 0){
            Destroy(enemy);
           // GameObject.sendMessage("ScoreUp", 100);
        }
    }


    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            Player script = (Player)player.GetComponent(typeof(Player));
            player.StartCoroutine("takeDamage");
        }
    }
}

