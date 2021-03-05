using UnityEngine;
using InvalidOperationException = System.InvalidOperationException;
public class Cannon : MonoBehaviour
{
    [SerializeField] private Transform pivotPoint;
    [SerializeField] private Rigidbody[] projectiles;
    
    private bool isLoaded = false;
    private int index;
    
    public void Load()
    {
        if (index >= projectiles.Length) throw new InvalidOperationException("Out of knights.");
        isLoaded = true;
        projectiles[index].useGravity = false;
        projectiles[index].transform.position = pivotPoint.position;
        projectiles[index].transform.rotation = pivotPoint.rotation;
    }
    public void Fire()
    {
        isLoaded = false;
        projectiles[index].useGravity = true;
        projectiles[index].AddForce(pivotPoint.up * 1000);
        index++;
    }
    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 150, 75), "Load") && !isLoaded) Load();
        if (GUI.Button(new Rect(100, 250, 150, 75), "Fire") && isLoaded) Fire();
    }
}