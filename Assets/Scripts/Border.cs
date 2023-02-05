using ColorsLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Border : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private static string _hashTag = "Border";

    public SpriteRenderer SpriteRenderer => _spriteRenderer;
    public static string HashTag => _hashTag;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.color = ColorData.GetRandomColor();
    }
}
