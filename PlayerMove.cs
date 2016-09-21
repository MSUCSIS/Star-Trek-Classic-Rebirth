using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	//no Rigidbodys
	public int speed = 25;
	public float turnspeed;
	public float tilt;
	public float eleSpeed;


	/*void Update () {
		//player move up/down/left/right/forward

		transform.Translate (Vector3.right * Input.GetAxis("Vertical") * speed * Time.deltaTime); //-Increase on X-Axis
		transform.RotateAround (transform.position, transform.up, Input.GetAxis("Horizontal") * Time.deltaTime * turnspeed); //-Rotate around Y-axis
		transform.Translate (Vector3.up * Input.GetAxis("Jump") * eleSpeed * Time.deltaTime); //-Increase on Y-Axis

		//-Rotate around the Z-Axis while button pressed
		//transform.RotateAround(transform.position, transform.right, Input.GetAxis("Vertical") * Input.GetAxis("Horizontal") * Time.deltaTime * -tilt);
	}*/

	void Update ()
	{
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.forward * -speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			transform.Rotate (Vector3.up, -turnspeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			transform.Rotate (Vector3.up, turnspeed * Time.deltaTime);
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            transform.Rotate(-Vector3.left * speed * Time.deltaTime);

    }
   

}