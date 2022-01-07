using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    // Referência ao script object Pool
    public ObjectPool pool;
         

    // Função responsável pelo instânciamento das moedas
    public void SpawnCoins(Vector3 position, float groundwidth)
    {
        int numberOfCoins = (int) Random.Range(3f, groundwidth);
        float y = Random.Range(5, 6);

        for (int i = 0; i < numberOfCoins; i++)
        {
            float x = position.x - (groundwidth / 2) +  1;
            GameObject coin = pool.GetPooledGameObject();
            
            coin.transform.position = new Vector3(
               x + i, position.y + y , position.z);
            
            coin.SetActive(true);
        }
    }

}
