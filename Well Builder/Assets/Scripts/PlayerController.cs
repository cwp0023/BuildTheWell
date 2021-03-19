using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float horizontalInput;
    public float verticalInput;
    public float xRange = 10; 
    private KeyCode key;
    //public float DeltaTime = 0.1f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /** /horizontalInput = horizontalInput.GetAxis("horizonatalInput");
        //verticalInput = verticalInput.GetAxis("verticalInput");
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } */
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
        }
    }
}
