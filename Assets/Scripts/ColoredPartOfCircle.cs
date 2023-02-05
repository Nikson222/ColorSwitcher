using ColorsLibrary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColoredPartOfCircle : MonoBehaviour
{
    private static string _hashTag = "Circle";
    [SerializeField] private Colors _color;
    private SpriteRenderer _spriteRenderer;

    public static string HashTag => _hashTag;
    public Colors Color => _color;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = ColorData.GetColor(_color);
    }
}
