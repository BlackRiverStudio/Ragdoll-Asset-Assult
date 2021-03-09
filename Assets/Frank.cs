using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }
    private void Update() { }

    private void OnCollisionEnter(Collision collision)
    {
        Pumpkin pumpkin =  GetComponentInParent<Pumpkin>();
        if (pumpkin) pumpkin.OnCollisionEnter(collision);
        else Debug.LogError("Frank no pumpkin ;-;");
    }
}