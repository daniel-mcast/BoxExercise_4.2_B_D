using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //create a variable to represent the player's speed
    [SerializeField]
    private float _speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        //set the player position at 0,0,0
        //0=x,0=y,0=z
        //Vector3 = Vector3(float x,float y,float z)
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //Translate(float x,float y,float z)
        //(-1 * fps,0,0) = fps e.g (-1 * 300 fps,0,0)
        //(-1 * sec,0,0) = (-1 * Time.deltaTime,0,0)
        //1m/s
        //-1 * Time.deltaTime = -1m/s (movement to the left)
        //1 * Time.delaTime = 1m/s (movement to the right)
        //to move the player to the left 1m/s (-1 * Time.deltaTime)
        //speed * Time.deltaTime
        //if we press right arrow move the player to the right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //move the player to the right
            transform.Translate(_speed * Time.deltaTime,0,0);
            gameObject.GetComponent<Renderer>().material.color = Color.blue; 
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            //move the player to the left
            transform.Translate(-_speed * Time.deltaTime,0,0);
            //turn player green when moving to the left
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }      
    }
}
