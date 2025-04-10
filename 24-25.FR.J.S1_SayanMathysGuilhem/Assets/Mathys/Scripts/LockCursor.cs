using UnityEngine;

public class LockCursor : MonoBehaviour
{

    [SerializeField] private KeyCode openshop = KeyCode.E;
    [SerializeField] GameObject Shop;
    [SerializeField] GameObject Mir;
    private bool touchactive;

    void Update()
    {
        if (Input.GetKeyDown(openshop))
        {
            if (touchactive == false)
            {
                touchactive = true;
                Cursor.visible = true;
                Shop.SetActive (true);
                Mir.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                touchactive = false;
                Cursor.visible = false;
                Shop.SetActive (false);
                Mir.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
