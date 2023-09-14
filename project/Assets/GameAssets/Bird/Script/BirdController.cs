using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    [SerializeField]
    public Transform Skin;

    private SpriteRenderer SpriteRenderer;
    Rigidbody2D rigidbody2D;
    private Vector3 BirdPositon;
    public float gravity = -9.8f;
    public float strength = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * 5f;
            //BirdPositon = Vector3.up * strength;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch .phase == TouchPhase.Began)
            {
                rigidbody2D.velocity = Vector2.up * 5f;
            }

            BirdPositon.y += gravity * Time.deltaTime;
            transform.position += BirdPositon * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.collider.CompareTag("Pipe") )
        {
            EditorApplication.ExitPlaymode();
        }
    }
}
