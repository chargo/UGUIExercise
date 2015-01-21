using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PadController : MonoBehaviour 
{
	public GameObject myAirCraft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnLeftButton()
	{
		//Debug.Log("OnLeftButton");
		myAirCraft.transform.DOLocalMoveX(-50.0f, 0.2f).SetRelative();
	}
	
	public void OnRightButton()
	{
		//Debug.Log("OnRightButton");
		myAirCraft.transform.DOLocalMoveX(50.0f, 0.2f).SetRelative();
	}
}
