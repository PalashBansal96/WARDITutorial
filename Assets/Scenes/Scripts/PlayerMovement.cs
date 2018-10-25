using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody _rigidbody;
	public float _acceleration = 1f;  //in ms^-2
	
	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>(); // Getting the attached Rigidbody component
	}
	
	// Update is called once per frame
	void Update () {
		
		//Basic movement with WASD
		if (Input.GetKey(KeyCode.A))
			_rigidbody.AddForce(-1*_acceleration * Time.deltaTime, 0, 0); //Note: acceleration is multiplied by Time.deltaTime to account for fps changes.
		if (Input.GetKey(KeyCode.D))
			_rigidbody.AddForce(_acceleration * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.S))
			_rigidbody.AddForce(0, 0, -1*_acceleration * Time.deltaTime);
		if (Input.GetKey(KeyCode.W))
			_rigidbody.AddForce(0, 0, _acceleration * Time.deltaTime);

		//Jumping
		if (Input.GetKeyDown(KeyCode.Space))
			_rigidbody.AddForce(0, _acceleration, 0);

	}
}
