using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform target; // La cible où l'objet doit se déplacer
    public float speed = 5f; // La vitesse de déplacement

    void Update()
    {
        // Déplacer l'objet vers la cible
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Vérifier si l'objet a atteint la cible
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            // Arrêter l'objet lorsqu'il atteint la cible
            transform.position = target.position;
        }
    }
}
