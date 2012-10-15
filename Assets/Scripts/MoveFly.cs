using UnityEngine;
using System.Collections;

public class MoveFly : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject,
			iTween.Hash(
			"path", iTweenPath.GetPath("path1"),
			"time", 20.0f
			)
		);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
