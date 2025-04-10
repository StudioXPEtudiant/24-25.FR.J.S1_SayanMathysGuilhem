using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    public CharacterController controleur;
    public float vitesse = 5.0f;
    public float vitesseCourse = 10.0f;
    public float forceSaut = 7.0f;
    private Vector3 vitesseVerticale;
    private bool estAuSol;

    void Update()
    {
        estAuSol = controleur.isGrounded;
        if (estAuSol && vitesseVerticale.y < 0)
        {
            vitesseVerticale.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 deplacement = transform.right * x + transform.forward * z;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            controleur.Move(deplacement * vitesseCourse * Time.deltaTime);
        }
        else
        {
            controleur.Move(deplacement * vitesse * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && estAuSol)
        {
            vitesseVerticale.y = Mathf.Sqrt(forceSaut * -2f * Physics.gravity.y);
        }

        vitesseVerticale.y += Physics.gravity.y * Time.deltaTime;
        controleur.Move(vitesseVerticale * Time.deltaTime);
    }
}
