using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pyramidController : MonoBehaviour {

	public Text myText;
	public Transform player=null;

	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)&&(player.position-transform.position).magnitude<20f )
		{
			myText.text="The God of this pyramid points you to the north.";
		}
		
	}
}
