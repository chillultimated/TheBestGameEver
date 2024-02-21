using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 9.8f;

    private float _fallVelocity = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _fallVelocity += gravity * Time.fixedDeltaTime;
        GetComponent<CharacterController>().Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);
    }
}
