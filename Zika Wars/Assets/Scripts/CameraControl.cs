using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    Transform player;
    public float xOffset;
    public float yOffset;
    public float zOffset;
    Vector3 playerPosition;
    public float valorX;
    public float valorY;
    public float valorZ;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerPosition.z = player.position.z - 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        playerPosition.x = player.position.x + xOffset;
        playerPosition.y = player.position.y + yOffset;

        valorX = player.position.x + xOffset;
        valorY = player.position.y + yOffset;
        valorZ = player.position.z;
        transform.position = playerPosition;
         
    }
}
