using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemy : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    private IEnumerator SpawnEnemies()
    {
        Debug.Log("remremremrere");
        while (EnemyCount < 10)
        {
            Debug.Log("remremremrere");
            xPos = Random.Range(-16, 13);
            zPos = Random.Range(-20, 1);
            Instantiate(theEnemy, new Vector3(xPos, -4, zPos), Quaternion.identity);
            yield return new WaitForSeconds(1);

            EnemyCount += 1;
        }
    }
}
