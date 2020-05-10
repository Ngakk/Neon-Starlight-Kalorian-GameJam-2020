using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpriteChooser : MonoBehaviour
{
    new public SpriteRenderer renderer;
    public Sprite[] options;

    public void Choose()
    {
        renderer.sprite = options[Random.Range(0, options.Length)];
    }
}
