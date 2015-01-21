using UnityEngine;
using System.Collections;

public class MessageBoxController : MonoBehaviour 
{
	public GameObject mainObject;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void OnStartButton()
	{
		Debug.Log("OnStartButton");
		
		mainObject.SetActive(false);
		
		// Call Start Battle
	}
	
	public void OnEndButton()
	{
		Debug.Log("OnEndButton");
	}
}
