using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_briser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bille")) //Compare les tags
        {
            Destroy(gameObject); //Détruit l'objet
        }
    }
}
