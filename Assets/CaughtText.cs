using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CaughtText : MonoBehaviour {

    [SerializeField]
	Text caught;

	void Start () {
		    FishDestinations.main.isAttached = false;
		    caught = gameObject.GetComponent<Text> ();
		    caught.text = "WASD to move / Mouse to look. Walk around the pond and catch fish!";
	}
	
	// Update is called once per frame
	void Update () {
		if (FishDestinations.main.isAttached == true) {
			caught.text = "You caught a fish! Press R to restart";
		}


	}
}
