using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    
    public GameObject Chest;

    void Start()
    {
        Chest.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Chest.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
