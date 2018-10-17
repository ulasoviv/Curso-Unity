using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controlador_Bola : MonoBehaviour {

	int cont=0;

	// Use this for initialization
	void Start () {
		Debug.Log ("HOLA MUNDO!");
	}
	
	// Update is called once per frame
	void Update () {
		if (cont <= 100) {
			Debug.Log (cont);
			cont=cont++;
			Debug.Log ("Somos los mejores." + cont);
		}
		
	}
}
