using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy;

    public GameObject EnemyTrigger;

    public Transform spawnPoint;

    //public int XPos;

    //public int ZPos;

    public int enemyCount;

    public int enemyMaxCount;


    // Start is called before the first frame update
    void Start()
    {
        //Enemy.transform.position = spawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Enemy.transform.position = spawnPoint.position;
    }

    private void OnTriggerEnter(Collider other)
    {

        enemyCount = 0;

        

        while (enemyCount < enemyMaxCount)
        {
            //Enemy.transform.position = spawnPoint.position;

            Instantiate(Enemy, spawnPoint);


            enemyCount += 1;
        }

        //Enemy.transform.position = spawnPoint.position;

        Invoke("DestroyCollider", 1f);

        //CallFunction();


    }

    void DestroyCollider()
    {
        Destroy(EnemyTrigger);
    }

    //void CallFunction()
    //{
    //    StartCoroutine(EnemyDrop());
    //}

    //IEnumerator EnemyDrop()
    //{
    //    while(enemyCount < 3)
    //    {
    //        XPos = Random.Range(1, 30);
    //        ZPos = Random.Range(1, 15);

    //        Instantiate(Enemy, new Vector3(XPos, 4, ZPos), Quaternion.identity);

    //        yield return new WaitForSeconds(0.1f);
    //        enemyCount += 1;
    //    }
    //}
}
