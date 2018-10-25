using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody _rigidbody;
	private bool _isTouchingFloor;
	
	//These public variables can be changed from the unity editor. Values initialized here are the default value when the script is attached to a Game Object.
	public float _acceleration = 180f;  //in ms^-2 
	public float _jumpImpulse = 250f;  //in ms^-2
	
	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>(); // Getting the attached Rigidbody component
		_isTouchingFloor = false;
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
		if (_isTouchingFloor && Input.GetKeyDown(KeyCode.Space))
		{
			_rigidbody.AddForce(0, _jumpImpulse, 0);
			_isTouchingFloor = false;
		}

	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Floor"))
			_isTouchingFloor = true;
	}
}
