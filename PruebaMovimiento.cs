using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaMovimiento : MonoBehaviour {

	public float velocidadSalto; 
	public float velocidadGiro; 
	public int entero;
	public GameObject Cubo;
	public GameObject Pared;
	public GameObject Pared2;

	private bool Variable=true;
	private Collider ColliderAuxiliar;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		entero  = 0;
		if (Input.GetKey(KeyCode.UpArrow)) 
		{ 
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * Time.deltaTime * velocidadGiro);
		} 

		if (Input.GetKey(KeyCode.DownArrow)) 
		{ 
			GetComponent<Rigidbody> ().AddForce (Vector3.back * Time.deltaTime * velocidadGiro);
		} 

		if (Input.GetKey(KeyCode.LeftArrow)) 
		{ 
			GetComponent<Rigidbody> ().AddForce (Vector3.left * Time.deltaTime * velocidadGiro);
		} 

		if (Input.GetKey(KeyCode.RightArrow)) 
		{ 
				GetComponent<Rigidbody> ().AddForce (Vector3.right * Time.deltaTime * velocidadGiro);
		
		} 

		if (true) 
		{ 
			if (transform.position.y < 1) {
				GetComponent<Rigidbody> ().AddForce (Vector3.up * Time.deltaTime * velocidadSalto);
			}
		} 





		}

	private void OnTriggerEnter (Collider other){


		if (other.gameObject.name=="CubeColision"){
			Debug.Log ("He entrado al cubo");
			Cubo.GetComponent<Rigidbody> ().AddForce (Vector3.up * Time.deltaTime * velocidadSalto);


		}
	
	} 

	private void OnTriggerExit (Collider other){


		if (other.gameObject.name == "CubeColision") {
			Debug.Log ("He salido del cubo");
			if (Variable == true) {
				Variable = false;

			}else {
				
				Variable = true;
			}
		}
		Pared.SetActive (Variable);
		Debug.Log (Variable);

		ColliderAuxiliar = other;
		Pared2.SetActive (false);
		Invoke ("DesaparecerPared", 3);



	}

	private void DesaparecerPared (){
		
		Pared2.SetActive (true);


	}



}
