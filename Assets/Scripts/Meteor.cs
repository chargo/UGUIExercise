using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Meteor : MonoBehaviour 
{	
	public float YDistance = 568.0f;
	public float XRange = 100.0f;
	public float Duration = 5.0f;
	
	public MeteorController controller;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Init(MeteorController inController)
	{
		controller = inController;
		gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(UnityEngine.Random.Range(-XRange, XRange), 0);
		Fly();
	}
	
	public void Fly()
	{		
		transform.DOLocalMoveY(-YDistance, Duration).SetRelative().OnComplete(FlyComplete).SetEase(Ease.Linear);
	}
	
	public void FlyComplete()
	{	
		controller.Score();
		gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(UnityEngine.Random.Range(-XRange, XRange), 0);
		Fly();
	}
}
