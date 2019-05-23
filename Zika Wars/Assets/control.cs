using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	float h;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxisRaw("Horizontal");

		if(Input.GetButtonDown("Jump")){
			Debug.Log ("jump");
		}

		if(Input.GetButtonDown("Fire3")){
			Debug.Log ("Fire3");
		}



		if(Input.GetButtonDown("Pause")){
			Debug.Log ("Pause");
		}


		if(h>0){
			Debug.Log (">0");
		}
		else if(h<0){
			Debug.Log ("<0");
		}

	}
}
