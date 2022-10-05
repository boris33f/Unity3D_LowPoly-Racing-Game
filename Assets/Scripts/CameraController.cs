using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject car;
    public float cameraSpeed = 1;


    void Update()
    {
        transform.position = new Vector3(car.transform.position.x, transform.position.y, car.transform.position.z);

        Vector3 heightAdjustment = car.transform.position - transform.position;
        heightAdjustment = new Vector3(0, Mathf.FloorToInt(heightAdjustment.y), 0);
        transform.Translate(heightAdjustment * Time.deltaTime * cameraSpeed);

        //transform.rotation = car.transform.rotation;
    }
}
