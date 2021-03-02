using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField] private Rigidbody pumpkin1;
    [SerializeField] private Rigidbody pumpkin2;
    [SerializeField] private Rigidbody pumpkin3;

    private GameObject pumpkinSplit1;

    private void Start()
    {
        // projectile = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //if (isLoaded)
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(pumpkin1.velocity.magnitude);
        if (pumpkin1.velocity.magnitude > 10)
        {
            print("OW");
            Destroy(gameObject);
        }
    }
}