using UnityEngine;
using System.Collections;

public class heyLook : MonoBehaviour {

	Transform lurePosition; //lerpysPosition

	// Use this for initialization
	void Start () {
		lurePosition = GameObject.Find ("Lure").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (lurePosition.position);
		transform.position += Time.deltaTime * transform.forward;


		//GameObject.Find ("Fish").isAttached;
	//	if isAttached = true; 
		//transform.forward (lerpysPosition.position);

		//transform.parent - if making a flock, use positions of parent object
		// SetParent - can use this to attach fish to lure
	}
}
