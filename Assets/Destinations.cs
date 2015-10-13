using UnityEngine;
using System.Collections;

public class Destinations : MonoBehaviour {
	
	private Transform startPoint, endPoint;
	public float percentage;
	private int direction;
	public float speed = 2; //speed will crash if at 0
	
	
	// Use this for initialization
	void Start () {
		
		startPoint = GameObject.Find ("StartPoint").transform;
		endPoint = GameObject.Find ("EndPoint").transform;
		direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage); //not "new" V3 because these numbers are already stored by computer
		transform.rotation = Quaternion.Lerp (Quaternion.identity, Quaternion.Euler ( new Vector3(-90, 120, 3)), percentage); //using Euler %, changes it to Quaternion. Needs 
		//a new Vector3 because the computer is not automatically storing these numbers.
		
		//if (speed == 0) speed = .000001f; //don't divide by zero
		
		speed = Mathf.Max (speed, .000001f); //if greater than zero speed, if less than 000001f. Can also Mathf.Clamp
		percentage += Time.deltaTime/speed * direction; //1/60 = frame rate
		
		//gameObject.GetComponent<Renderer> ().material.color = Color.Lerp (Color.red, Color.cyan, percentage);
		
		//keep percentage within range
		//switch direction
		if ((percentage > 1) || (percentage < 0)) {
			direction= -direction;
			percentage = Mathf.Clamp(percentage, 0, 1);
			
		}
	}
}
