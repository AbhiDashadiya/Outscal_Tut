using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] public GameObject tankPrefb;
    

    void Start()
    {
        Instantiate(tankPrefb,transform.position,Quaternion.identity);
    }

    
}
