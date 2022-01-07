using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    [SerializeField]
    // Ponto de inicio
    Transform groundPoint;

    public ObjectPool[] groundPoolers;
    float[] groundWidths;

    [SerializeField]
    Transform minHeightPoint;

    [SerializeField]
    Transform maxHeightPoint;

    float minY;
    float maxY;

    [SerializeField]
    float minGap;

    [SerializeField]
    float maxGap;

    CoinGenerator coinGenerator;


    // Start is called before the first frame update
    void Start()
    {
        minY = minHeightPoint.position.y;
        maxY = maxHeightPoint.position.y;

        groundWidths = new float[groundPoolers.Length];
        for (int i = 0; i < groundPoolers.Length; i++)
        {
            groundWidths[i] = groundPoolers[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }

        coinGenerator = FindObjectOfType<CoinGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < groundPoint.position.x)
        {
            int random = Random.Range(0, groundPoolers.Length);
            float distance = groundWidths[random] / 2;

            float gap = Random.Range(minGap, maxGap);
            float height = Random.Range(minY,maxY);

            transform.position = new Vector3(
                transform.position.x + distance + gap, height,transform.position.z);
            GameObject ground = groundPoolers[random].GetPooledGameObject();
            ground.transform.position = transform.position;
            ground.SetActive(true);

            coinGenerator.SpawnCoins(
                transform.position,
                groundWidths[random]
                );


            transform.position = new Vector3(
               transform.position.x + distance, transform.position.y, transform.position.z); 

        }
    }
}
