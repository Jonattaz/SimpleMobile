using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Referência ao jogador
    Player player;

    // Ultima posição do jogador
    Vector3 lastPosition;

    // Armazena a diferença entre a última posição do jogador e a posição atual
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        lastPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - lastPosition.x;
        transform.position = new Vector3(transform.position.x + distance,
            transform.position.y, 
            transform.position.z);
        lastPosition = player.transform.position;

    }
}
