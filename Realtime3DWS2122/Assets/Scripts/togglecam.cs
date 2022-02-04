using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglecam : MonoBehaviour
{
   public Camera Modell1; 
   public Camera Modell2; 
   public Camera Modell3; 

   public void switchcam(int x) {
  deactivateall();
 if (x ==1)
 {
Modell1.enabled = true; 
 }
 else if (x ==2)
 {
Modell2.enabled = true; 
 }
 else {
Modell3.enabled = true; 
 }
   }

public void deactivateall() {
    Modell1.enabled = false; 
    Modell2.enabled = false;
    Modell3.enabled = false; 
}
}
