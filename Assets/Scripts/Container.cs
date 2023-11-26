using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public GameObject fruit;
    public GameObject fruitInContainer;
    public GameObject greenLight;

    public GameObject flowerMid;
    public GameObject starFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit"))
        {
            fruit.SetActive(false);
            fruitInContainer.SetActive(true);
            greenLight.SetActive(true);
            StartCoroutine("WaterPlant");
        }
    }
    IEnumerator WaterPlant()
    {
        yield return new WaitForSeconds(10);
        fruitInContainer.SetActive(false);
        flowerMid.SetActive(true);
        starFX.SetActive(true);

    }
}
