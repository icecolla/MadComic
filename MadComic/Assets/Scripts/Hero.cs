using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private Rigidbody2D _rb;
    private float hor;
    private float ver;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(hor, ver) * speed;
    }
}
