using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{ 
public Transform SpawnPoint;
 public int PlayerLife;
 bool respawn = false;
 void OnCollisionEnter(Collision col){
     if (col.gameObject.name == "rumba") {
         PlayerLife = 0;
     }
 }
     
 void Update () {
     if (PlayerLife <= 0) {
         respawn = true;
     } 
     else {
         respawn = false;
     }
     if (respawn) {
         transform.position = SpawnPoint.position;
         PlayerLife = 100;
     }
 }
}
