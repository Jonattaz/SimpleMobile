using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    public Renderer background;

    [SerializeField]
    float backgroundSpeed;

    // Update is called once per frame
    void Update()
    {
        background.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
