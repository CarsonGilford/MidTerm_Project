using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatWalk : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //if player holds down UP ARROW, then move up
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position += new Vector3(0f, 0.1f, 0f);
        }

        //if Player holds down RIGHT ARROW, then move right
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(0.1f, 0f, 0f);
            //Change Sprite Direction
            Vector3 characterScale = transform.localScale;
            characterScale.x = -1;
            transform.localScale = characterScale;
        }

        //if Player holds down DOWN ARROW, then move down
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position += new Vector3(0f, -0.1f, 0f);
        }

        //if Player holds down LEFT ARROW, then move left
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += new Vector3(-0.1f, 0f, 0f); 
            //Change Sprite Direction
            Vector3 characterScale = transform.localScale;
            characterScale.x = 1;
            transform.localScale = characterScale;
        }
    }
}
