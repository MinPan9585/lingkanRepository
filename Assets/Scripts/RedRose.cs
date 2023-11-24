using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedRose : MonoBehaviour
{
    float redRoseTimer = 0f;

    public GameObject redParticles;
    public GameObject greenLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        redRoseTimer += Time.deltaTime;
        if (redRoseTimer > 3f)
        {
            redParticles.SetActive(true);
            greenLight.SetActive(true);
        }
    }
}
