using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Data.prefabCount--;
            Data.score += 10;
            this.gameObject.SetActive(false);
        }
       
    }
}
