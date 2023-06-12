using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    [Header("Setting")]

    [SerializeField] private GameObject DeathScreen;

    [SerializeField] private float jumpVelocity = 20; //сила

    [SerializeField] private GameObject PlayerUI;

    private Animator animation; //аним

    private Rigidbody2D rigidbody;

    private bool jump = false;  //проверка земли под ногами 

    private void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();  //объявление появления
       animation = GetComponent<Animator>();  //анимация с старта
       Time.timeScale = 1f; 
    }
    
    private void Update()
    
    {
        if(Input.GetKey (KeyCode.Space) && jump == false)
        {
            rigidbody.velocity = new Vector3(0, jumpVelocity, 0);
            animation.SetBool("Jump", true);
            jump = true;
        }
    }
      private void OnCollisionEnter2D(Collision2D other)

    {
        if(other.gameObject.tag == "LocationTemplate")
        {
            animation.SetBool("Jump", false); 
            jump = false; 
        }

        if(other.gameObject.tag == "Obstacle")
        {
            DeathScreen.SetActive(true); //сме
            PlayerUI.SetActive(false);
            Time.timeScale = 0f; 
        }
    }
}
