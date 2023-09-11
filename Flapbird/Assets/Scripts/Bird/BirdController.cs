using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float JumpForce = 0.1f;

    Rigidbody2D BirdRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        BirdRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    void HandleJump()
    {
        if ( Input.GetButtonDown("Jump") )
        {
            BirdRigidbody2D.AddForce(new Vector3(0, JumpForce, 0), ForceMode2D.Impulse);
        }
    }
}
