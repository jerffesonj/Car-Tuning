using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            other.transform.position = new Vector3(-110, 0, -90);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.transform.rotation = Quaternion.Euler(0, 90,0);
        }
    }
}
