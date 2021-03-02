using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField] private Rigidbody projectile;

    private GameObject pumpkinSplit1;

    private void Start()
    {
        projectile = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //if (isLoaded)
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(projectile.velocity.magnitude);
        if (projectile.velocity.magnitude > 10)
        {
            print("OW");
            //Instantiate(pumpkin2.gameObject, transform);
        }
    }
}