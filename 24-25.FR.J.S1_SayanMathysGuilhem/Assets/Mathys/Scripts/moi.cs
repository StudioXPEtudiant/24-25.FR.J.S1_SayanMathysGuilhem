using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class moi : MonoBehaviour
{
    [SerializeField] GameObject Achaa;
    public int price;
    //[SerializeField] Animator Panim;
    //[SerializeField] Animator Danim;
    [SerializeField] GameObject Panimm;
    [SerializeField] GameObject Danimm;
    [SerializeField] GameObject shopitem;
    public int CurrentCoins;
    public int coinsCount;
    public Text coinsCountText;
    public static moi instance;
    public Rigidbody2D rb2d; 
    public float Speed = 5;
    public float jumpSpeed = 8;
    bool isGrounded = true;

    void Start()
    {
        Panimm.SetActive(true);
        Danimm.SetActive(false);
        CurrentCoins = coinsCount;
        rb2d =  GetComponent<Rigidbody2D>();
    }

    public void AchaS()
    {
        if (CurrentCoins >= price && coinsCount >= price)
        {
            shopitem.SetActive (false);
            Achaa.SetActive (false);
            Debug.LogWarning ("Acheter");
            Panimm.SetActive(false);
            Danimm.SetActive(true);
            CurrentCoins -= price;
            coinsCount -= price;
            coinsCountText.text = coinsCount.ToString();
            Speed = 12;
            jumpSpeed = 14;
            //Panim.runtimeAnimatorController = Danim.runtimeAnimatorController;
        }
        Debug.LogWarning("nonnon");
    }

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Debug.LogWarning("nn");
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void AddCoins(int count)
    {
        CurrentCoins += count;
        coinsCount += count;
        coinsCountText.text = coinsCount.ToString();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Speed;

        rb2d.velocity = new Vector2(h, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            StartCoroutine("JumpCoolDown");
            rb2d.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
        }
    }

    IEnumerator JumpCoolDown()
 {
    yield return new WaitForSeconds(1);
    isGrounded = true;
 }
}
