using UnityEngine;
using System.Collections;

public class Mig : MonoBehaviour {
	
	
	public Transform fire1;
	public Transform fire2;
	
	public GameObject missile;
	
	private Transform tr;
	private Transform playerTr;
	
	private float missileTime;
	
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform>();
		playerTr = GameObject.Find ("fighter").GetComponent<Transform>();
		
		//Mathf.SmoothDampAngle
//		fire1 = GetComponentInChildren<Transform>
		
		tr.LookAt(playerTr);
		rigidbody.AddForce(tr.forward * 10.0f);
		
		missileTime = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		tr.LookAt(playerTr);
		rigidbody.AddForce(tr.forward * 10.0f);
		
		missileTime += Time.deltaTime;
		
		if (missileTime > 0.25f)
		{
			missileTime = 0;
			
			Transform t = fire1;
			
			{
				GameObject m = (GameObject)Instantiate(missile, t.position, t.rotation);
				m.rigidbody.AddForce(t.transform.forward * 5000.0f);
			}
			
			t = fire2;
			{
				GameObject m = (GameObject)Instantiate(missile, t.position, t.rotation);
				m.rigidbody.AddForce(t.transform.forward * 5000.0f);
			}
}
	}
}
