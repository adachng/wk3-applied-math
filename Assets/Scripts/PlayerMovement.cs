using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 yourname = new Vector3();
       if (Input.GetKey("w"))
        {
            yourname.z += Time.deltaTime * speed;
            Debug.Log("W is pressed!");
        }

         if (Input.GetKey("a"))
        {
            yourname.x -= Time.deltaTime * speed;
            Debug.Log("A is pressed!");
        }

         if (Input.GetKey("s"))
        {
            yourname.z -= Time.deltaTime * speed;
            Debug.Log("W is pressed!");
        }

         if (Input.GetKey("d"))
        {
            yourname.x += Time.deltaTime * speed;
            Debug.Log("W is pressed!");
        }

        transform.position += yourname;
    }

    void FixedUpdate()
    {

    }
}
