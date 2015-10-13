using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FishDestinations : MonoBehaviour {

	public Transform lure;
	public  bool isMoving = false;
	public float speed = 5.0f;
	public Transform[] target;
	private int newNum;
	public bool isAttached = false;
	private float distance, fishDist;
	public static FishDestinations main; 


	void Awake () 
		{
		main = this;    
		}
	

	void Start(){
		lure = GameObject.Find ("Lure").transform;

	}

	void Update(){

		/*if (lurePosition = ___) { //must add distance within to make fish move toward lure
		transform.LookAt (lerpysPosition.position);
			transform.position += Time.deltaTime * transform.forward;
		}
		if (lurePosition =  ){ //add distance within to make fish attach to lure object
			SetParent //attach fish to Lure object
		}
*/
		distance = Vector3.Distance (transform.position, lure.position);
		//Debug.Log ("distance" + distance);

		if(isMoving == false)
		{ 
			newNum = Random.Range(0, target.Length); 
			isMoving = true;

		}



		if ( (distance < 10 || isAttached == true) && fishDist < 15 ) {
			transform.position = Vector3.MoveTowards (transform.position, lure.position, speed * Time.deltaTime);
			transform.LookAt (lure.position);//.GetComponent(typeof(Transform)) as Transform
		} else {
			transform.position = Vector3.MoveTowards(transform.position, target[newNum].position, speed * Time.deltaTime);
			fishDist = Vector3.Distance (transform.position, target[newNum].position);
			transform.LookAt (target[newNum].position);
		}

		if (transform.position == target [newNum].position) { 
			isMoving = false;
		}
		
		if (transform.position == lure.position) { 
			isAttached = true;
			transform.SetParent(lure); 

				Debug.Log ("fish was attached");


		}
		
}

	}
	




