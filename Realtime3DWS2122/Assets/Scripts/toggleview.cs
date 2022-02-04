using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleview : MonoBehaviour
{
    public Camera FlaschenAnsicht; 
    public Camera DeckelAnsicht;
    public Camera HandleAnsicht; 

    public void switchcamera (int x) {
        deactivateall();
        if (x==1)
        {
            FlaschenAnsicht.enabled = true; 

        }
        else if (x==2)
        {
            DeckelAnsicht.enabled = true; 

        }
        else {
            HandleAnsicht.enabled = true; 

        }
    } 
   public void deactivateall(){
       FlaschenAnsicht.enabled = false; 
       DeckelAnsicht.enabled = false;
       HandleAnsicht.enabled = false; 

   }
}
