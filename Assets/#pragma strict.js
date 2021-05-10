#pragma strict
var jumpHeight=5;

function Start () { 

}

function Update () {
if(Input.GetKeyDown(KeyCode.Space))
GetComponent.<Rigidbody2D>().velocity.y=jumpHeight;

}

