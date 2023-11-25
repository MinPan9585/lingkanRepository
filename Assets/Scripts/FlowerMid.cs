using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMid : MonoBehaviour
{
    public GameObject upHalf;
    public GameObject lowHalf;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Knife"))
        {
            upHalf.SetActive(true);
            lowHalf.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}
