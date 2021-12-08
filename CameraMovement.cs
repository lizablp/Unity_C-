using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float moveSpeed = 0.2f;

    public float rotateSpeed;
    Vector3 Vec;
    float speed = 1f;
    float delta = 3f;  //delta is the difference between min y to max y.

    void Start()
    {
        transform.Rotate(0, 0, 0, Space.World);

    }

    void Update()
    {



        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * 20);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * 20);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * 20);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * 20);
        }
        else if (Input.GetKey(KeyCode.F))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime*20);
        }

        else if (Input.GetKey(KeyCode.B))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime*20);
        }

            if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0.02f * rotateSpeed, 0, Space.World);
            Vector3 rotationToAdd = new Vector3(0, 10, 0);
            transform.Rotate(rotationToAdd);
        }
    }
}



