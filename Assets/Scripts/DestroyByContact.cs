using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {



	void OnTriggerEnter(Collider other) {
		Debug.Log (other.tag);
		if (other.tag == "Boundary") 
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);

	}
}
