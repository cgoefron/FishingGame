#pragma strict


var target : Transform[];
var isMoving : boolean = false;


var speed : float = 5.0f;

private var newNum : int; //added for debugging
public var isAttached : boolean = false;

function Update()
{ 
   
   if(isMoving == false)
	{ 
	    newNum = Random.Range(0, target.length ); //replace transform with random number, random not working. Does array start from zero?
	    isMoving = true;
	   
	}
    transform.position = Vector3.MoveTowards(transform.position, target[newNum].position, speed * Time.deltaTime);
    transform.LookAt(target[newNum].position);
    //temporarily replace newTarget with target[newNum] to select transform from the target array

    if (transform.position == target[newNum].position) //use Vector3.dist < .01f
	{ 
	    isMoving = false;
	    isAttached = true;
    }
    
}