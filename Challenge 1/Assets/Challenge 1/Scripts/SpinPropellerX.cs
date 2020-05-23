using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    //public GameObject plane;

    private float spinSpeed = 4000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Spin the propeller about the Z-axis
        //transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

    }
}
