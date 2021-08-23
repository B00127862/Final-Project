using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ThirdPcontroller : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float turnTime = 0.1f;
    float turnSmooth;
    public int hasKey;
    public TextMeshProUGUI keyText;
    public TextMeshProUGUI doorText;
    public AudioSource pickUp;
    




    // Update is called once per frame

    void Start()
    {
        pickUp = GetComponent<AudioSource>();
        


    }




    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmooth, turnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        keyText.text = "Soul Fragments: " + hasKey;
         if(hasKey == 3)
        {
            doorText.text = "The door is now unlocked";
            
        }

        


    }
            public void OnTriggerEnter(Collider other)
    { if (other.CompareTag("Key"))
        {
            hasKey +=1;
            Destroy(other.gameObject);
            pickUp.Play();
            
        
        
        
        }

        if (other.CompareTag("Death"))
        {
            SceneManager.LoadScene("DEATHMEN");




        }

        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene("WIN");




        }
        
        if (other.CompareTag("next"))
        {
            SceneManager.LoadScene("LVL1 2");




        }

        if (other.CompareTag("Door") && hasKey == 3)
        {

            Destroy(other.gameObject);
        
        }



        







    }
    


}
