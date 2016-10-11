using UnityEngine;
using Leap;
using System.Collections;

public class Ball : MonoBehaviour {

	public float speed = 1.0f;
	
	private HandModel GetHand(Collider other)
	{
		if (other.transform.parent && other.transform.parent.parent.parent &&
		    other.transform.parent.parent.GetComponent<HandModel> ())
			return other.transform.parent.parent.GetComponent<HandModel> ();
		else
			return null;
	}
	void onTriggerEnter(Collider other)
	{
		HandModel handModel = GetHand (other);
		if (handModel != null) {
			speed ++;
			
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
