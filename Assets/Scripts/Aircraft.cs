using UnityEngine;
using System.Collections;

public class Aircraft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnTriggerEnter(Collider other) 
	{
		Debug.LogWarning("OnTriggerEnter: " + other.name);
	}
}
