using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject planet;
    public float spinSpeed;
    public int axis_x;
    public int axis_y;
    public int axis_z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (axis_x != 0)
        {
            transform.RotateAround(planet.transform.position, Vector3.right, spinSpeed * Time.deltaTime);
        }

        if (axis_y != 0)
        {
            transform.RotateAround(planet.transform.position, Vector3.up, spinSpeed * Time.deltaTime);
        }

        if (axis_z != 0)
        {
            transform.RotateAround(planet.transform.position, Vector3.forward, spinSpeed * Time.deltaTime);
        }
    }
}
