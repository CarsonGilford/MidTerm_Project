using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Purpose: Movment code and raycast for destroying door through button press
    //Usage:Place and player charecter for simple destroy object and movment code.
   
    float myMaxRayDist = 1.7f;
    public float movementSpeed;
    Vector2 movementVector;
    Vector2 oriantation;
    string Door = "Door";
    string Human = "Human";

    string Door2 = "Door2";

    public int openDoor;
    
    void Update()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.y = Input.GetAxis("Vertical");
        movementVector = movementVector.normalized;

        if(movementVector != Vector2.zero) oriantation = movementVector;

        transform.position += new Vector3(movementVector.x,movementVector.y,0) * Time.deltaTime * movementSpeed;

        //Sprite Flip
        if (Input.GetKey(KeyCode.LeftArrow)){
            //Change Sprite Direction
            Vector3 characterScale = transform.localScale;
            characterScale.x = 0.6784236f;
            transform.localScale = characterScale;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            //Change Sprite Direction
            Vector3 characterScale = transform.localScale;
            characterScale.x = -0.6784236f;
            transform.localScale = characterScale;
        }
        if (Input.GetKey(KeyCode.A)){
            //Change Sprite Direction
            Vector3 characterScale = transform.localScale;
            characterScale.x = 0.6784236f;
            transform.localScale = characterScale;
        }
        if (Input.GetKey(KeyCode.D)){
            //Change Sprite Direction
            Vector3 characterScale = transform.localScale;
            characterScale.x = -0.6784236f;
            transform.localScale = characterScale;
        }

        //Raycast Code
        Ray2D myRay = new Ray2D(transform.position, oriantation);
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDist);
        //Debug.DrawRay(myRay.origin, myRay.direction * myMaxRayDist, Color.yellow);

        //For openeing door to bedroom
        if(myRayHit.collider != null &&  Input.GetKey(KeyCode.P)){
            GameObject go = GameObject.Find (Door);
        //if the tree exist then destroy it
        if (go){
            Destroy (go.gameObject);
            Debug.Log("Raycast is hitting" + myRayHit.collider.name);
        }
        }
        //Delete human and  delete front door allows dog out
        if(myRayHit.collider != null &&  Input.GetKey(KeyCode.L)){
            GameObject go = GameObject.Find(Human);
        //if the tree exist then destroy it
        if (go){
            Destroy (go.gameObject);
            openDoor +=1;
            Debug.Log("Raycast is hitting" + myRayHit.collider.name);
        }
        }
        if(openDoor >= 1){
            Destroy(GameObject.Find(Door2));
            Debug.Log("dead");
        }
    }
    
}
