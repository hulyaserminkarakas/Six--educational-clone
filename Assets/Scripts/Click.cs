using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {


	void Start () {



	}


	void Update () {

		if(Input.GetMouseButtonDown(0)){

			Vector2 ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray, Vector2.zero);

			if (hit.collider != null) {
				Destroy (hit.transform.gameObject);
			}
		
		}

	}
}
