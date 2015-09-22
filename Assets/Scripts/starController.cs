using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class starController : MonoBehaviour {

	public float turnSpeed=15f;
	public Text myText;
	public Transform player=null;
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime);
		transform.eulerAngles+=new Vector3(0f, -turnSpeed*Time.deltaTime, 0f);
		if(Input.GetKeyDown(KeyCode.Space)&&(player.position-transform.position).magnitude<20f )
		{
			myText.text="This star does not point north, but it does point right.";
		}
		
	}
}
