using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform hipPosition;
    public Transform headPosition;
    public Transform BShipPosition;
    public Transform BSheadPosition;
    public GameObject Crosshair;
    public KeyCode switchKey = KeyCode.E;
    
    private Transform weapon;
    public Transform bulletSpawn;
    private bool isAtHip = true;

    void Start()
    {
        weapon = transform;
        weapon.rotation = hipPosition.rotation;
        weapon.position = hipPosition.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (isAtHip)
            {
                weapon.position = headPosition.position;
                weapon.rotation = headPosition.rotation;
                bulletSpawn.position = BSheadPosition.position;
                bulletSpawn.rotation = BSheadPosition.rotation;
                isAtHip = false;
                Crosshair.SetActive (false);
            }
            else
            {
                weapon.position = hipPosition.position;
                weapon.rotation = hipPosition.rotation;
                bulletSpawn.position = BShipPosition.position;
                bulletSpawn.rotation = BShipPosition.rotation;
                isAtHip = true;
                Crosshair.SetActive (true);
            }
        }
    }
}

