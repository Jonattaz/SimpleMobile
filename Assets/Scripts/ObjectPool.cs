using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    // Objeto que será usado no object pool
    public GameObject pooledObject;

    [SerializeField]
    // Quantidade de objetos
    int numberOfObjects;

    // Lista que reserva os objetos
    List<GameObject> gameObjects;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = new List<GameObject>();
        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject gameObject = Instantiate(pooledObject);
            gameObject.SetActive(false);
            gameObjects.Add(gameObject);
        }
    }


    public GameObject GetPooledGameObject()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            if (!gameObject.activeInHierarchy)
                return gameObject;
        }

        GameObject gameObject1 = Instantiate(pooledObject);
        gameObject1.SetActive(false);
        gameObjects.Add(gameObject1);
        return gameObject1;


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
