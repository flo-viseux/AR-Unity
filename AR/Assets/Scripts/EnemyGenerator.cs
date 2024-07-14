using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    #region SerializedFields
    [SerializeField] private Enemy enemyPrefab;

    [SerializeField] private Vector2 delay;

    [SerializeField] private Vector2 randomX;
    [SerializeField] private Vector2 randomZ;
    #endregion

    #region UnityMethods
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    #endregion

    #region Private
    private IEnumerator SpawnEnemy()
    {
        float i = Random.Range(delay.x, delay.y);
        float X = Random.Range(randomX.x, randomX.y);
        float Z = Random.Range(randomZ.x, randomZ.y);

        yield return new WaitForSeconds(i);

        Enemy instance = Instantiate(enemyPrefab, new Vector3(X, 0, Z), Quaternion.identity, this.transform);

        StartCoroutine(SpawnEnemy());
    }
    #endregion
}
