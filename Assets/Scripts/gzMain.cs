using UnityEngine;
using System.Collections;

public class gzMain : MonoBehaviour {

	// Use this for initialization
	void OnDrawGizmos () {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
