using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Meteor : MonoBehaviour {

	public float YDistance = 568.0f;
	public float XRange = 100.0f;
	public float Duration = 5.0f;

	// Use this for initialization
	void Start () {
		Fly();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Fly()
	{		
		transform.DOLocalMoveY(-YDistance, Duration).SetRelative().OnComplete(FlyComplete).SetEase(Ease.Linear);
	}
	
	public void FlyComplete()
	{	
		gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(UnityEngine.Random.Range(-XRange, XRange), 0);
		Fly();
	}
}
