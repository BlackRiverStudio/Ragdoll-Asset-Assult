using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cannon : MonoBehaviour
{
    public bool isLoaded = false;
    [SerializeField] private Transform pivotPoint;
    [SerializeField] private Rigidbody projectile;
    public void Load()
    {
        print("Load()");
        isLoaded = true;

        projectile.useGravity = false;
        projectile.transform.position = pivotPoint.position;
    }
    public void Fire()
    {
        print("Fire()");
        isLoaded = false;

        projectile.useGravity = true;
        projectile.AddForce(pivotPoint.up * 1000);
    }
    private void Update()
    {
        
    }
    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 150, 75), "Load"))
        {
            if (!isLoaded) Load();
        }
        if (GUI.Button(new Rect(100, 250, 150, 75), "Fire"))
        {
            if (isLoaded) Fire();
        }
    }
}