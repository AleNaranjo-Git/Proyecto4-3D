using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public GameObject blood;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Lifes>().Lost();
            Instantiate(blood, other.transform.position, Quaternion.identity);
        }
    }
}