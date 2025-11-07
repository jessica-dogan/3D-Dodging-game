using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    public float moveSpeed;
   // float xInput;
 public FixedJoystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     // Get joystick input instead of Input.GetAxis
        float xInput = joystick.Horizontal;
        // if you want vertical movement too:
        // float yInput = joystick.Vertical
       // xInput = Input.GetAxis("Horizontal");

        transform.Translate(xInput * moveSpeed * Time.deltaTime, 0, 0);



        if(transform.position.y < -5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Stone")
        {
            //restart the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }



}
