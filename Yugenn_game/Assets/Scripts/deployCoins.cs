using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCoins : MonoBehaviour
{

    public GameObject coinPrefab;
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coinFlow());
    }

    private void spawnCoin()
    {
        GameObject a = Instantiate(coinPrefab) as GameObject;
    }

    IEnumerator coinFlow()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCoin();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
