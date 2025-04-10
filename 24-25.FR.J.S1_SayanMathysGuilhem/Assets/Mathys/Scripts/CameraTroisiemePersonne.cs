using UnityEngine;

public class CameraTroisiemePersonne : MonoBehaviour
{
    public Transform cible;  // Transform du joueur à suivre
    public Vector3 offset;   // Offset de la caméra par rapport au joueur
    public float sensibiliteSouris = 10.0f;
    public float distanceMin = 2.0f;
    public float distanceMax = 15.0f;

    private float rotationY = 0.0f;
    private float rotationX = 0.0f;
    private float distanceActuelle;

    void Start()
    {
        distanceActuelle = offset.magnitude;
        Vector3 angles = transform.eulerAngles;
        rotationY = angles.y;
        rotationX = angles.x;
        Cursor.lockState = CursorLockMode.Locked; // Verrouiller le curseur de la souris
    }

    void LateUpdate()
    {
        if (cible)
        {
            rotationY += Input.GetAxis("Mouse X") * sensibiliteSouris;
            rotationX -= Input.GetAxis("Mouse Y") * sensibiliteSouris;
            rotationX = Mathf.Clamp(rotationX, -35, 60);

            Quaternion rotation = Quaternion.Euler(rotationX, rotationY, 0);
            distanceActuelle = Mathf.Clamp(distanceActuelle - Input.GetAxis("Mouse ScrollWheel") * 5, distanceMin, distanceMax);
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distanceActuelle) + cible.position + offset;

            transform.rotation = rotation;
            transform.position = position;
        }
    }
}
