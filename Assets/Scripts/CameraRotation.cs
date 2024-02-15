﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform CameraAxisTransform;

    public float RotationSpeed;
    void Start()
    {
        
    }
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);
        CameraAxisTransform.localEulerAngles = new Vector3(CameraAxisTransform.localEulerAngles.x + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y"), 0, 0);
    }
}
