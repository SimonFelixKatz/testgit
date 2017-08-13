using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[SerializeField]
	Transform start;
	[SerializeField]
	GameObject[] platforms;
	[SerializeField]
	float platformSize = 0f;
	[SerializeField]
	int platformNumber = 5;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < platformNumber; i++) {
			GameObject.Instantiate (platforms [Random.Range (0, platforms.Length)], start.position + new Vector3 (10f * i, 0f, 0f),Quaternion.identity);
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
