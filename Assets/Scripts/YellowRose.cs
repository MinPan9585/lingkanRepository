using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowRose : MonoBehaviour
{
    public GameObject redParticleOnR;
    public GameObject redParticlesOnY;
    public GameObject greenLightOnY;

    public GameObject starOne;
    public GameObject starTwo;

    public GameObject roseRed;
    public GameObject roseYellow;

    public GameObject fruit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Brush"))
        {
            redParticlesOnY.SetActive(true);
            greenLightOnY.SetActive(true);

            StartCoroutine("FinishFirstStep");
        }
    }

    
    IEnumerator FinishFirstStep()
    {
        yield return new WaitForSeconds(3);

        redParticleOnR.SetActive(false);
        redParticlesOnY.SetActive(false);

        Destroy(roseRed);
        roseYellow.SetActive(false);

        starOne.SetActive(true);
        starTwo.SetActive(true);

        fruit.SetActive(true);
    }
}
