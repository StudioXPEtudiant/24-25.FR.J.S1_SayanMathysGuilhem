using UnityEngine;

public class CameraPremierePersonne : MonoBehaviour
{
    public float sensibiliteSouris = 100f;
    public Transform corpsJoueur;
    private float rotationX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Verrouiller le curseur de la souris
    }

    void Update()
    {
        float sourisX = Input.GetAxis("Mouse X") * sensibiliteSouris * Time.deltaTime;
        float sourisY = Input.GetAxis("Mouse Y") * sensibiliteSouris * Time.deltaTime;

        rotationX -= sourisY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        corpsJoueur.Rotate(Vector3.up * sourisX);
    }
}
