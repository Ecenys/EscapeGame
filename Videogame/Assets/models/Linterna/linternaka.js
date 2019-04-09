#pragma strict

var encendida : boolean;
public var linterna : Light;

function Start () {

}

function Update () {
	if (Input.GetKeyDown("mouse 1")){
	encendida = !encendida;
		if (encendida){
			linterna.enabled = false;
		}
		
		else{
			linterna.enabled = true;
		}
	}	
}