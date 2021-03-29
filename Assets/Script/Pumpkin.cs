using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField] private Rigidbody pumpkin;
    [SerializeField] private Rigidbody[] pumpkinHalves = new Rigidbody[2];
    [SerializeField] private Rigidbody[] pumpkinQuarters = new Rigidbody[4];
    [SerializeField] private float radius = 3;

    private void Start()
    {
        pumpkin.gameObject.SetActive(true);
        foreach (Rigidbody half    in pumpkinHalves)   half.gameObject.SetActive(false);
        foreach (Rigidbody quarter in pumpkinQuarters) quarter.gameObject.SetActive(false);
    }

    /// <summary></summary>
    /// <param name="_rb"></param>
    /// <returns></returns>
    public static float KineticEnergy(Rigidbody _rb) => 0.5f * _rb.mass * Mathf.Pow(_rb.velocity.magnitude, 2);
    // mass in kg, velocity in meters per second, result is joules

    public void OnCollisionEnter(Collision _collision)
    {
        Vector3 heading = transform.position - _collision.transform.position;
        Vector3 direction = heading / heading.magnitude;
        float kinetic = KineticEnergy(_collision.gameObject.GetComponent<Rigidbody>());
            
        print(_collision.gameObject.name + ": " + direction.z + " + " + kinetic + " = " + direction.z * kinetic);
        
        if (_collision.gameObject.name.Contains("Knight")) _collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        
        if (kinetic > 20)
        {
            print("20+");
            pumpkin.gameObject.SetActive(false);
            
            foreach (Rigidbody quarter in pumpkinQuarters)
            {
                quarter.gameObject.SetActive(true);
                quarter.AddExplosionForce(direction.z * kinetic, transform.position, radius);
            }
        }
        else if (kinetic > 10)
        {
            print("10+");
            pumpkin.gameObject.SetActive(false);
            
            foreach (Rigidbody half in pumpkinHalves)
            {
                half.gameObject.SetActive(true);
                half.AddExplosionForce(direction.z * kinetic, transform.position, radius);
            }
        }
    }
}