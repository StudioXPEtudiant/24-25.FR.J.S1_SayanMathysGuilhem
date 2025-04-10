using UnityEngine;

public class ViserArme : MonoBehaviour
{
    public Camera cameraJoueur;
    public Transform positionViser;
    public Transform positionRepos;
    public float vitesseViser = 5f;

    private bool estEnTrainDeViser = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            estEnTrainDeViser = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            estEnTrainDeViser = false;
        }

        if (estEnTrainDeViser)
        {
            cameraJoueur.transform.position = Vector3.Lerp(cameraJoueur.transform.position, positionViser.position, vitesseViser * Time.deltaTime);
            cameraJoueur.transform.rotation = Quaternion.Lerp(cameraJoueur.transform.rotation, positionViser.rotation, vitesseViser * Time.deltaTime);
        }
        else
        {
            cameraJoueur.transform.position = Vector3.Lerp(cameraJoueur.transform.position, positionRepos.position, vitesseViser * Time.deltaTime);
            cameraJoueur.transform.rotation = Quaternion.Lerp(cameraJoueur.transform.rotation, positionRepos.rotation, vitesseViser * Time.deltaTime);
        }
    }
}
