using UnityEngine;
using System.Collections;

public class CameraMinimap : MonoBehaviour {
	
	public Transform playerTr;
	public Transform tr;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform>();
		playerTr = GameObject.Find ("fighter").GetComponent<Transform>();

		tr.position = playerTr.position + (Vector3.up * 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
		tr.position = playerTr.position + (Vector3.up * 10.0f);
	}
}
