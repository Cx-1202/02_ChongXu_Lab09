using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float speed;
    float rotatespeed = 200.0f;

    public Transform Player;
    public GameObject Positiontext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if ( Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0,0,Time.deltaTime * speed);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if ( Input.GetKey(KeyCode.S))
        {
            //transform.position += new Vector3(0, 0, Time.deltaTime * -speed);
            transform.position += transform.forward * -speed * Time.deltaTime;
        }


        if ( Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotatespeed, 0));
        }
        else if ( Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotatespeed, 0));
        }

        Positiontext.GetComponent<Text>().text = "Position" + Player.position.ToString(); 
    }
}
