using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: show how to aim turret and fire hitscan wepon based on mouse aiming
//Usage:put this on player turret obj face east (+x axis)
public class MouseAim : MonoBehaviour
{
    public GameObject explodePreFab; // assign in Inspector
    // Update is called once per frame
    void Update()
    {
        //Mouse aiming: always face towrds mouse cursor position
        Vector3 mouseCursorPosInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 fromPlayerToMouseCursor =  mouseCursorPosInWorld - transform.position;
        transform.right = fromPlayerToMouseCursor; //rotate to align my "right" with vec towrds mouse cursor
        Debug.DrawRay(transform.position, fromPlayerToMouseCursor, Color.yellow);

        //raycast from player towrds mouse cursor, and then instatiate something at impact point.
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myMaxRayDist = 10f;
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDist);

        //did we hit something if so instatiate something at impact point
        if(myRayHit.collider !=null && Input.GetMouseButtonDown(0)){
            //institiat explostion at impact point
            Instantiate(explodePreFab, myRayHit.point, Quaternion.Euler(0,0,0));
            Debug.Log("Raycast is hitting" + myRayHit.collider.name);

             //Destroy (delete raycasthit
            Destroy(myRayHit.collider.gameObject);
            

        }

    }
}
