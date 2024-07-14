using UnityEngine;

public class Player : MonoBehaviour
{
    #region SerializedFields
    [SerializeField] private Projectile projectile;
    #endregion

    #region API
    public static Player Instance = null;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    private void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    #endregion

    #region Private
    private void Fire()
    {
        Projectile instance = Instantiate(projectile, this.transform.position, this.transform.rotation);
    }
    #endregion
}
