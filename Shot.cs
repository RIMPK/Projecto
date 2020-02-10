using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField]
    private Vector2 _direction;
    [SerializeField]
    private float _speed;

    public Vector2 Direction
    {
        get { return _direction;}
        set { _direction = value.normalized;}
    }
    public float Velocity 
    {
        get {return _speed;}
        set 
        {
            if (value > 0)
            {
                _speed = value;
            }
            else
            {
                _speed = 0;
            }
        }
    }
    public Shot (Vector2 d, float s)
    {
        _direction = d.normalized;
        _speed = s;
    }

    /* 2nd metodo 
    public Shot (float dx, float dy, float px, float py, float s)
    {
        _direction.x = dx;
        _direction.y = dy;
        _position.x = px;
        _position.y = py;
        _speed = s;
    }
    */

    public Shot() { }

    public void move()
    {
        transform.position = new Vector3(
            transform.position.x + _speed * Time.deltaTime * _direction.x,
            transform.position.y + _speed * Time.deltaTime * _direction.y,
            0);
    }
    public void Update()
    {
            move();
    }
}

