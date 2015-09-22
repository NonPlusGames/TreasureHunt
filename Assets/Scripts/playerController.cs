using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.D))
		{
				transform.position+=new Vector3(21f,0f,0f)*Time.deltaTime;
				transform.eulerAngles= new Vector3(0f,90f,0f);
		}
		if(Input.GetKey (KeyCode.W))
		{
			transform.position+=new Vector3(0f,0f,21f)*Time.deltaTime;
			transform.eulerAngles= new Vector3(0f,0f,0f);
		}
		if(Input.GetKey (KeyCode.S))
		{
			transform.position+=new Vector3(0f,0f,-21f)*Time.deltaTime;
			transform.eulerAngles= new Vector3(0f,180f,0f);
		}
		if(Input.GetKey (KeyCode.A))
		{
			transform.position+=new Vector3(-21f,0f,0f)*Time.deltaTime;
			transform.eulerAngles= new Vector3(0f,270f,0f);
		}
		Camera.main.transform.position=transform.position+ new Vector3(0f,20f,-10f);
	}
}
