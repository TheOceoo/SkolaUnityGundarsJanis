using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sword : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) // piejams  ja collider ir set to trigger
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            other.GetComponent<Player>().ShowEndScreen();
        }
    }

}
