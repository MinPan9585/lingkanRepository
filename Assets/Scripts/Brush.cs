using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public GameObject redParticlesOnBrush;
    public GameObject greenLightOnBrush;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedRose"))
        {
            redParticlesOnBrush.SetActive(true);
            greenLightOnBrush.SetActive(true);
        }
        


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
