using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] lanePrefabs;
    public float spawnHorizon = 500f;
    public float laneWidth = 2f;
    public GameObject player;
    public Transform spawnerParent;

    private float nextLaneOffset = 0f;
	
	void Update ()
    {
        float forwardPosition = player.transform.position.z;
        float horizontalPosition = player.transform.position.x;
        while (nextLaneOffset < spawnHorizon + forwardPosition)
        {
            int randomLaneIndex = Random.Range(0, lanePrefabs.Length);
            GameObject lane = lanePrefabs[randomLaneIndex];
            Vector3 nextLanePosition = nextLaneOffset * Vector3.forward;
            GameObject newLaneObject = Instantiate(lane, nextLanePosition + (horizontalPosition * Vector3.right), Quaternion.identity) as GameObject;
            newLaneObject.transform.parent = spawnerParent;
            nextLaneOffset += laneWidth;
        }
	}
}
