using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private MoveBehaviour _moveb;
    public GameObject shotprefab;
    public Transform shotStart;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Update()
    {
        /*
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation*= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);*/

        if (Input.GetAxis("Vertical")>0)
        {
            _moveb.move(transform.up);
        }
        if (Input.GetAxis("Vertical")<0)
        {
            _moveb.move(transform.up*-1);
        }
        if (Input.GetAxis("Horizontal")>0)
        {
            _moveb.move(transform.right);
        }
        if (Input.GetAxis("Horizontal")<0)
        {
            _moveb.move(transform.right*-1);
        }

    }

    public void Awake()
    {
        _moveb = GetComponent<MoveBehaviour>();
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _moveb.move(new Vector2(1, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _moveb.move(new Vector2(-1, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _moveb.move(new Vector2(0, 1));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _moveb.move(new Vector2(0, -1));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shotprefab, shotStart.position, Quaternion.identity);
        }


    }
}
