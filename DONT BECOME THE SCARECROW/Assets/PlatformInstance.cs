using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformInstance : MonoBehaviour {
	[SerializeField]
	GameObject[] obstacles;
	[SerializeField]
	Transform[] obstaclePositions;
	// Use this for initialization
	void Start () {
		GameObject.Instantiate (obstacles [Random.Range (0, obstacles.Length)], obstaclePositions[Random.Range(0,obstaclePositions.Length)].position,Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
