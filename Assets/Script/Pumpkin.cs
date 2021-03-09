using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField] private Rigidbody pumpkin;
    [SerializeField] private Rigidbody[] pumpkinQuarters = new Rigidbody[4];
    [SerializeField] private float radius = 3;

    private void Start() { foreach (Rigidbody quarter in pumpkinQuarters) quarter.gameObject.SetActive(false); }

    private void Update() { }

    /// <summary></summary>
    /// <param name="_rb"></param>
    /// <returns></returns>
    public static float KineticEnergy(Rigidbody _rb) => 0.5f * _rb.mass * Mathf.Pow(_rb.velocity.magnitude, 2);
    // mass in kg, velocity in meters per second, result is joules

    public void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.name.Contains("Knight"))
        {
            Rigidbody knightRb = _collision.gameObject.GetComponent<Rigidbody>();
            Thing(knightRb);
            //float knightKinetic = Thing(knightRb);
            knightRb.constraints = RigidbodyConstraints.None;
            if (KineticEnergy(knightRb) > 5)
            {
                print("big hit");
                foreach (Rigidbody quarter in pumpkinQuarters)
                {
                    quarter.gameObject.SetActive(true);
                    quarter.AddExplosionForce(KineticEnergy(knightRb), transform.position, radius);
                }
            }
        }
    }

    private void Thing(Rigidbody _rb)
    {
        Vector3 heading = transform.position - _rb.transform.position;
        Vector3 direction = heading / heading.magnitude;
        print(_rb.gameObject.name + ": " + direction.z + " + " + KineticEnergy(_rb) + " = " + direction.z * KineticEnergy(_rb));
    }
}