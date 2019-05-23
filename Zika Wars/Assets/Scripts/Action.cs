using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Action : MonoBehaviour {
    
    public Sprite attack;
    public Sprite spawner;
    public Sprite door;

    // Use this for initialization
    void Start (){
        }

    void Update(){

    }

    public void changeSpriteAttack(){
        this.transform.GetComponent<Image>().sprite = attack;
    }

    public void changeSpriteSpawner(){
            this.transform.GetComponent<Image>().sprite = spawner;
    }

    public void changeSpriteDoor(){
            this.transform.GetComponent<Image>().sprite = door;
    }
}
