using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Algae")
        {
            other.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Algae")
        {

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Algae")
        {
            other.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}