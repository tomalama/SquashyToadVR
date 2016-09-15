using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {
	
	private float speed;
    	private float length;

	void Start ()
    	{
        	float lifeTime = length / speed;
        	Invoke("Remove", lifeTime);
	}
	
    	void Remove()
    	{
        	Destroy(gameObject);
    	}

	void Update ()
    	{
        	transform.position += Vector3.right * speed * Time.deltaTime;
	}

    	public void SetPath (float someSpeed, float someLength)
    	{
        	speed = someSpeed;
	 	length = someLength;
    	}
}
