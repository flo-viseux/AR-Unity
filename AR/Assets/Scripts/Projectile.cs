using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    #region SerializedFields
    private Rigidbody rb = null;

    private float speed = 100f;
    #endregion

    #region UnityMethods
    private void OnEnable()
    {
        rb.AddForce(transform.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
            Destroy(this.gameObject);
    }
    #endregion

    #region Private
    private IEnumerator AutoDestroy()
    {
        yield return new WaitForSeconds(3f);

        Destroy(this.gameObject);
    }
    #endregion
}
