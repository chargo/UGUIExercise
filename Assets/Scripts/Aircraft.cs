using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Aircraft : MonoBehaviour 
{
	public MessageBoxController messageBox;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnTriggerEnter(Collider other) 
	{
		Debug.LogWarning("OnTriggerEnter: " + other.name);
		DOTween.Kill();
		messageBox.Show();
	}
}
