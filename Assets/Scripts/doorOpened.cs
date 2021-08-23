using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorOpened : MonoBehaviour

{

    public ThirdPcontroller controller;
    public AudioSource doorOpen;
 
    // Start is called before the first frame update
    void Start()
    {
        doorOpen = GetComponent<AudioSource>();
        controller = GameObject.Find("Player").GetComponent<ThirdPcontroller>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door") && controller.hasKey == 3)
        {

            doorOpen.Play();

        }





    }


}
