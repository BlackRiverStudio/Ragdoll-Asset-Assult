using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField] private Rigidbody pumpkin;

    private GameObject pumpkinSplit1;

    private void Start()
    {
        pumpkin = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //if (isLoaded)
    }

    private void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.name.Contains("Knight"))
        {
            Rigidbody knightRigidbody = _collision.gameObject.GetComponent<Rigidbody>();
            print(knightRigidbody.constraints);
            knightRigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}