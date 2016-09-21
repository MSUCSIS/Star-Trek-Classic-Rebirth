using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public Transform Sun;
	public float x;
	public float y;
	public float z;

	void Update () 
	{
		Vector3 relativePos = (Sun.position + new Vector3(0, 500f, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);

		Quaternion current = transform.localRotation;

		transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
		transform.Translate(x, y, z * Time.deltaTime);
	}
}

