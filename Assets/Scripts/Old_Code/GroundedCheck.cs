using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Purpose:show how to use raycast to detect if an object is on the ground or floor
// Usage: put this script on square thats 1m wide and tall hovering abve a ground object

public class GroundedCheck : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //if we are on the ground do nothing

        //1. declare rayobject or variable
        Ray2D myRay = new Ray2D(transform.position, Vector2.down);
        
        //2. define maximum raycast distance
        float maxRayDist = 0.6f;
    
        //3.visulize raycast in scene view
        Debug.DrawRay(myRay.origin, myRay.direction * maxRayDist, Color.yellow);

        //4. atcully fire raycast
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, maxRayDist);

        //5. See if the raycast actully hit something?
        if(myRayHit.collider !=null){
            //do nothing
            Debug.Log("Raycast is hitting" + myRayHit.collider.name);

        }else{
            //...but if were in air spin
            transform.Rotate(0, 0, 30f * Time.deltaTime); //spin 30 degrees per second
        }
        


        //if in air spin
    }
}
