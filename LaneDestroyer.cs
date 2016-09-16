using UnityEngine;
using System.Collections;

public class LaneDestroyer : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}
