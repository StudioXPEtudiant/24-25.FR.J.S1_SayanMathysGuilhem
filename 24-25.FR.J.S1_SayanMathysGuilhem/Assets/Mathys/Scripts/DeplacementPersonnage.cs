using UnityEngine;

public class DeplacementPersonnagetest : MonoBehaviour
{
    public float vitesse = 5.0f;
    public float vitesseCourse = 10.0f;
    public float forceSaut = 7.0f;
    private bool estAuSol = true;  
    // vérifier si le personnage est au sol
    //[SerializeField] private string horizontalMoveInput = "Horizontal";
    //[SerializeField] private string verticalMoveInput = "Vertical";
    [SerializeField] private string MouseXInput = "Mouse X";
    [SerializeField] private string MouseYInput = "Mouse Y";
    [SerializeField] private float mouseSensitivity = 2.0f;
    [SerializeField] private float upDownRange = 80.0f;
    private Rigidbody rb;
    private Camera mainCamera; 
    private float verticalRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 deplacement = new Vector3();
        float vitesseActuelle = vitesse;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            vitesseActuelle = vitesseCourse;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            deplacement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            deplacement += Vector3.back;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            deplacement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            deplacement += Vector3.right;
        }

        transform.Translate(deplacement * vitesseActuelle * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space) && estAuSol)
        {
            rb.AddForce(Vector3.up * forceSaut, ForceMode.Impulse);
            estAuSol = false;
        }
        HandleRotation();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            estAuSol = true;
        }
    }

    //rotation joueur
    void HandleRotation()
    {
        float mouseXRotation = Input.GetAxis(MouseXInput) * mouseSensitivity * Time.deltaTime;
        float mouseYRotation = Input.GetAxis(MouseYInput) * mouseSensitivity * Time.deltaTime;
        transform.Rotate(0, mouseXRotation,0);

        verticalRotation -= Input.GetAxis(MouseYInput) * mouseSensitivity;
        verticalRotation -= Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        mainCamera.transform.Rotate(-mouseYRotation,0,0);
        mainCamera.transform.Rotate(Vector3.left,mouseXRotation);
    }    
}

