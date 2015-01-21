using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MeteorController : MonoBehaviour 
{
	public static string PrefabPath = "Prefabs/Meteor";
	public List<GameObject> meteorList = new List<GameObject>();
	
	public int CurrentScore = 0;
	
	public Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Generate()
	{
		GameObject thisNewMeteor = Instantiate( (GameObject)Resources.Load(PrefabPath)) as GameObject;
		thisNewMeteor.transform.SetParent(transform);
		thisNewMeteor.GetComponent<Meteor>().Init(this);
		meteorList.Add(thisNewMeteor);
	}
	
	public void KillAll()
	{
		if(meteorList == null || meteorList.Count == 0)
			return;
			
		for(int i = meteorList.Count -1; i >= 0; i--)
			Destroy(meteorList[i]);
	}
	
	public void Score()
	{
		CurrentScore++;
		scoreText.text = CurrentScore.ToString();
	}
	
	public void ResetScore()
	{
		CurrentScore = 0;
		scoreText.text = CurrentScore.ToString();
	}
}
