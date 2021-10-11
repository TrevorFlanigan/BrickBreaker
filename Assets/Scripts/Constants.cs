using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Constants : MonoBehaviour 
 {
     public static Constants GM;
     public static Vector2 initialSpeed = new Vector2(-9.8f * 10, -9.8f * 10);

    public static int numCols = 20;    
    public static int numRows = 3;    
     void Awake()
     {
         if(GM != null)
             GameObject.Destroy(GM);
         else
             GM = this;
         
         DontDestroyOnLoad(this);
     }
 }
