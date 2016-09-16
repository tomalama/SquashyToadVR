using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

    public GameObject[] vehiclePrefabs;
    public float heightOffset = 1f;
    public float startOffset = -10f;
    public float speed = 5.0f;
    public float length = 10.0f;
    public float maxSpawnTime = 10f;

    private Vector3 positionOffset;
    private int randomLaneIndex;

    void Start ()
    {
        StartCoroutine("Spawn");
	}

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, maxSpawnTime));
            InstantiateVehicle();
        }
    }

    Vector3 GetPositionOffset()
    {
        positionOffset = transform.position;
        positionOffset += heightOffset * Vector3.up;
        positionOffset += startOffset * Vector3.right;
        return positionOffset;
    }

    void InstantiateVehicle()
    {
        randomLaneIndex = Random.Range(0, vehiclePrefabs.Length);
        GameObject vehicleObject = Instantiate(vehiclePrefabs[randomLaneIndex]);
        vehicleObject.transform.position = GetPositionOffset();
        vehicleObject.transform.parent = transform;

        Vehicle vehicleComponent = vehicleObject.GetComponent<Vehicle>();
        vehicleComponent.SetPath(speed, length);

    }
}
