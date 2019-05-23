using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    GameObject player;
    GameObject mainCamera;
    public GameObject exit;
    Vector3 cameraPosition;
    public float cameraPositionX;
    public float cameraPositionY;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        cameraPosition.z = mainCamera.transform.position.z;
        cameraPosition.x = cameraPositionX;
        cameraPosition.y = cameraPositionY;
    }

    void update(){

    }
	
    IEnumerator openDoor()
    {
        yield return new WaitForSeconds(0.5f);
        player.transform.position = exit.transform.position;
        //mainCamera.transform.position = cameraPosition;
        this.GetComponent<Animator>().SetBool("open", false);
        yield return null;
    }


}
