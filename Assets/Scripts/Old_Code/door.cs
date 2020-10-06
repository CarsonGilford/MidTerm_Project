using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
 void Update()
 {     
     if(Input.GetKeyDown(KeyCode.Space)){
        Destroy(gameObject);
        Debug.Log("Space key was pressed.");
     }   
 }
 
}
