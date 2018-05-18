using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	void Start () {
		
	}


	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
	
		if (other.gameObject.name == "Bottom") {
		
			print ("Game Over");
		
		}
	
	}

}
