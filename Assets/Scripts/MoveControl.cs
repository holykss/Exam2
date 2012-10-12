using UnityEngine;
using System.Collections;

public class MoveControl : MonoBehaviour {
	
	public Transform playerTr;
	public float speed = 10.0f;
	
	public Transform firePos1;
	public Transform firePos2;
	
	public GameObject missile;
	
	public AnimationClip flyBack;
	
	private int fireSeq = 0;
	
	// Use this for initialization
	void Start () {
//		playerTr = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis ("Vertical");
		
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
		
		transform.Rotate (Vector3.up * Time.deltaTime * h * 10.0f);
		
		playerTr.Rotate (-Vector3.forward * Time.deltaTime * h * 20.0f);
		
		transform.Rotate (Vector3.right * Time.deltaTime * v * 10.0f);
		//playerTr.Translate(Vector3.right * Time.deltaTime * 10 * h);
		
		if (h != 0)
		{
//			playerTr.rotation.z = Time.deltaTime * h;
		}
		else
		{
			//playerTr.rotation = new Vector3(0,0,0);
		}
		
		if (Input.GetButtonDown("Jump"))
		{
			fireSeq ++;
			if (fireSeq % 2 ==1)
			{
				GameObject missile1 = (GameObject)Instantiate(missile, firePos1.position, firePos1.rotation);
				missile1.rigidbody.AddForce(firePos1.transform.forward * 5500.0f);
			}
			else
			{
				GameObject missile2 = (GameObject)Instantiate(missile, firePos2.position, firePos2.rotation);
				missile2.rigidbody.AddForce(firePos2.transform.forward * 50500.0f);
			}

		}
		
		if (Input.GetButtonDown("Fire1"))
		{
			if (!animation.isPlaying)
			{
				animation.clip = flyBack;
				animation.Play();
			}
		}
	
	}
}
