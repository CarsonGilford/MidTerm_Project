using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Update is called once per frame
    float myMaxRayDist = 1.7f;
    public float movementSpeed;
    Vector2 movementVector;
    Vector2 oriantation;
    string Door = "Door";
    //public AudioSource bark;

    //public GameObject PreFab_Door;
  
    void Update()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.y = Input.GetAxis("Vertical");
        movementVector = movementVector.normalized;

        if(movementVector != Vector2.zero) oriantation = movementVector;

        transform.position += new Vector3(movementVector.x,movementVector.y,0) * Time.deltaTime * movementSpeed;

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

        Ray2D myRay = new Ray2D(transform.position, oriantation);
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDist);
        Debug.DrawRay(myRay.origin, myRay.direction * myMaxRayDist, Color.yellow);

        if(myRayHit.collider != null && Input.GetMouseButtonDown(0)){
            GameObject go = GameObject.Find (Door);
            //if the tree exist then destroy it
        if (go){
            Destroy (go.gameObject);
            Debug.Log("Raycast is hitting" + myRayHit.collider.name);
        }
        }
    }
    
}
