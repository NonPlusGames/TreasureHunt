using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mirrorController : MonoBehaviour {

	public Text myText;
	public Transform player=null;
	
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space)&&(player.position-transform.position).magnitude<20f )
		{
			myText.text="That which you seek finds solace in an embrace of land.";
		}
		
	}
}
