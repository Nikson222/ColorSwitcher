using ColorsLibrary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 1;
    [SerializeField] private Transform _startPosition;
    private Rigidbody2D _rigidBody;
    private SpriteRenderer _spriteRenderer;

    private Colors currentColor; 

    private static string _hashTag;

    public SpriteRenderer SpriteRenderer => _spriteRenderer;
    public static string HashTag => _hashTag;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _hashTag = GetComponent<Collider2D>().tag;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidBody.velocity = Vector3.up * _jumpForce;
    }

    private void Repainted(Color color)
    {
        _spriteRenderer.color = color;
    }

    private void ResetPlayerPositionToStart()
    {
        transform.position = _startPosition.position;
    }

    private void ResetColorToDefault()
    {
        _spriteRenderer.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(ColoredPartOfCircle.HashTag))
        {
            Repainted(collision.gameObject.GetComponent<SpriteRenderer>().color);
        }

        if (collision.tag.Equals(Border.HashTag))
        {
            Color borderColor = collision.gameObject.GetComponent<SpriteRenderer>().color;
            if (!borderColor.Equals(_spriteRenderer.color))
            {
                ResetPlayerPositionToStart();
                ResetColorToDefault();
            }
        }

        if (collision.tag.Equals(ReturnBorder.HashTag))
        {
            Jump();
        }
    }
}
