using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public GameObject roseInHand;
    public GameObject roseInEarth;
    public GameObject starFX;
    public GameObject greenLightFX;
    public GameObject bigRose;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinalRose"))
        {

        }
    }
}
