using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: demonstarte Robot sensing walla infornt of it and turning to explore maze
//Usage: put this on obj face along +x axis(red axis)
public class RobotStearing : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Always move Forward(move along x axis)
        transform.Translate(2f*Time.deltaTime, 0f, 0f);//move 3 meters per second

        //Raycast in front of us and randomly turn +/- 90 degrees left or right if there is a wall
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myMaxRayDist = 1.1f;
        Debug.DrawRay(myRay.origin, myRay.direction * myMaxRayDist, Color.yellow);

        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDist);

        //Did raycast hit something?
        if(myRayHit.collider != null){
            //.. Randomly turn left or right
            float randomNumber = Random.Range(0, 100);
            if (randomNumber < 50){//50% chance to turn left
                transform.Rotate(0, 0, 90f);
            }else{
                transform.Rotate(0, 0, -90f);
            }
        }
    }
}
