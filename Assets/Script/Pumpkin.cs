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
            Vector3 heading = transform.position - knightRb.transform.position;
            Vector3 direction = heading / heading.magnitude;
            float knightKinetic = KineticEnergy(knightRb);
            print(knightRb.gameObject.name + ": " + direction.z + " + " + knightKinetic + " = " + direction.z * knightKinetic);
            if (knightKinetic > 10) { print("10+"); }
            else if (knightKinetic > 20)
            {
                print("20+");
                pumpkin.gameObject.SetActive(false);
                foreach (Rigidbody quarter in pumpkinQuarters)
                {
                    quarter.gameObject.SetActive(true);
                    quarter.AddExplosionForce(direction.z * knightKinetic * 10, transform.position, radius);
                }
            }
            knightRb.constraints = RigidbodyConstraints.None;
        }
    }
}