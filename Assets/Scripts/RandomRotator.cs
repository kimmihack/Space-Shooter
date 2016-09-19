using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour 
{
	public float tumble;

	void Start ()
	{
		Rigidbody asteroidBody = GetComponent<Rigidbody> ();
		asteroidBody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
