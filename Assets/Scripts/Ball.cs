using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update


     // whenever the ball or stone goes out of the camera detroy game object
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }



}
