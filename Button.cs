using System.Collections;
using Systems.Collections.Generic;
using UnityEngine ;


public class Button : MonoBehavior
 {
    public Animator Button;
    public Animator toOpen;
    
    void Start()
    {
         button.enabled = false;
    }
    
    
    private void OnTriggerEnter (Collider other)
     {
         button.enabled = true;
         toOpen.enabled = true;
     }
  {
