using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeteorController : MonoBehaviour 
{
	public static string PrefabPath = "Prefabs/Meteor";
	public List<GameObject> meteorList = new List<GameObject>();

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
		thisNewMeteor.GetComponent<Meteor>().Init();
		meteorList.Add(thisNewMeteor);
	}
	
	public void KillAll()
	{
		if(meteorList == null || meteorList.Count == 0)
			return;
			
		for(int i = meteorList.Count -1; i >= 0; i--)
			Destroy(meteorList[i]);
	}
}
