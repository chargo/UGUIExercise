using UnityEngine;
using System.Collections;

public class MessageBoxController : MonoBehaviour 
{
	public GameObject mainObject;
	public MeteorController meteorController;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void Show()
	{
		mainObject.SetActive(true);
		meteorController.KillAll();
	}
	
	public void Hide()
	{
		mainObject.SetActive(false);
	}
	
	public void OnStartButton()
	{
		Debug.Log("OnStartButton");
		Hide();		
		meteorController.Generate();
	}	
}
