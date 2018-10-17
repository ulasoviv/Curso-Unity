using UnityEngine;

public class ConFisicas : MonoBehaviour
{
	public float thrust;
	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{


		if (Input.GetKey(KeyCode.UpArrow)) 
		{ 
			rb.AddForce(transform.forward * thrust);
		} 

		if (Input.GetKey(KeyCode.DownArrow)) 
		{ 
			rb.AddForce(transform.up * thrust);
		} 

		if (Input.GetKey(KeyCode.LeftArrow)) 
		{ 
			
		} 

		if (Input.GetKey(KeyCode.RightArrow)) 
		{ 
			rb.AddForce(transform.right * thrust);
		} 

	

	}
}