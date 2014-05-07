using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;

	void Start () {


		rigidbody.velocity = transform.forward * speed;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
