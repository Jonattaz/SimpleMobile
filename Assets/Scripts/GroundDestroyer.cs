using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroyer : MonoBehaviour
{
    private GameObject endPoint; 
    // Start is called before the first frame update
    void Start()
    {
        endPoint = GameObject.Find("GroundEndPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < endPoint.transform.position.x)
        {
            gameObject.SetActive(false);
        }
    }
}
