using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
        
        
        anim.SetFloat("horizontal", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("vertical", Input.GetAxisRaw("Vertical"));





    }



}
