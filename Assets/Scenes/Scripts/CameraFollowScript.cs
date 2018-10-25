using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

	public Transform _player;

	private Vector3 _startDelta;
	// Use this for initialization
	void Start ()
	{
		_startDelta = _player.position - transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = _player.position - _startDelta;
	}
}
