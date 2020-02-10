using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    private MoveBehaviour _movebehaviour;
    [SerializeField]
    private Vector3[] points = new Vector3[4];
    [SerializeField]
    private float speed;
    public void Awake()
    {
        _movebehaviour = GetComponent<MoveBehaviour>();
    }
    public void Start()
    {
        /*
        _arraytest2[2] = new Chest(true, 10);
        _movebehaviour.move(new Vector3[0](x))*/
    }

    public void FixedUpdate()
    {
        _movebehaviour.move();
    }
}
