using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demarrer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void detruirePlatforme()
    {
        Destroy(gameObject); //Détruit l'objet ciblée par la fonction
    }
}
