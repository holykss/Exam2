using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {
	public GameObject lbReady;
	public Hashtable ht = new Hashtable();
	
	
	// Use this for initialization
	void Start () {
		ht.Add("y", -1.5f);	
		ht.Add("time", 2.0f);
		ht.Add("delay", 0.7f);
		ht.Add("easetype", iTween.EaseType.easeOutBounce);
		
//		iTween.MoveBy(lbReady, ht);
		iTween.MoveBy(lbReady, iTween.Hash(
			"y", -1.5f, 
			"time", 2.0f, 
			"delay", .3f, 
			"easetype", iTween.EaseType.easeOutBounce,
			"oncompletetarget", gameObject,
			"oncomplete", "HideReadyText"
			));
	}
	
	void HideReadyText()
	{
		iTween.MoveBy(lbReady, iTween.Hash(
			"y", +1.5f, 
			"time", 1.0f, 
			"delay", .5f, 
			"easetype", iTween.EaseType.easeOutBounce
			));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
