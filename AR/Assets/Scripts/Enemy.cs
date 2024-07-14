using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    #region SerializedFields
    [SerializeField] private NavMeshAgent agent;
    #endregion

    #region UnityMethods
    private void Update()
    {
        agent.SetDestination(Player.Instance.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
    #endregion
}
