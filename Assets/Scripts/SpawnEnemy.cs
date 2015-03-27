using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour 
{
	bool isSpawning = false;
	public float minTime;
	public float maxTime;
	public float maxSpawn;
	private float spawned = 0;
	public GameObject[] buildings;  // Array of enemy prefabs.

		
	IEnumerator SpawnObject(int index, float seconds)
	{
		Debug.Log ("Waiting for " + seconds + " seconds");
		
		yield return new WaitForSeconds(seconds);
		Instantiate(buildings[index], transform.position, transform.rotation);

		
		//We've spawned, so now we could start another spawn     
		isSpawning = false;
	}
	
	void Update () 
	{
		//We only want to spawn one at a time, so make sure we're not already making that call
		if(! isSpawning && spawned<maxSpawn)
		{
			isSpawning = true; //Yep, we're going to spawn
			int enemyIndex = Random.Range(0, buildings.Length);
			spawned += 1;
			Debug.Log(spawned);
			StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
		}
	}
}