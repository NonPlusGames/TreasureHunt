using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour {

	public Transform player=null;
	public int time=0;
	public Text myText;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)&&(player.position-transform.position).magnitude<20f )
		{
			myText.text="YOU WIN!!!";
			Debug.Log("USDA");
			transform.position=new Vector3(transform.position.x, 3f, transform.position.z);
		}
	}
}
