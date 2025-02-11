using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class redemarerScene : MonoBehaviour
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
            Invoke("restartLevel", 5f); // Invoque le recharge de scéne
        }
    }

    void restartLevel()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharge la scène
    }

}
