using UnityEngine;
using System.Collections;

public class MoveControl : MonoBehaviour {
	
	private Transform playerTr;
	public float speed = 10.0f;
	
	// Use this for initialization
	void Start () {
		playerTr = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		playerTr.Translate(Vector3.forward * Time.deltaTime * speed);
	
	}
}
