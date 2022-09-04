using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A fish
/// </summary>
public class Fish : MonoBehaviour
{
    #region Fields

    [SerializeField]
    GameObject prefabExplosion;

    int damage = 100;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the damage the fish inflicts
    /// </summary>
    public int Damage
    {
        get { return damage; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Fires the fish
    /// </summary>
    private void OnMouseUpAsButton()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(0, 5000),
            ForceMode2D.Impulse);
    }

    /// <summary>
    /// Destroy fish on collision
    /// </summary>
    /// <param name="collision">collision info</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // only explode on collision with teddy bear
        if (collision.gameObject.CompareTag("TeddyBear"))
        {
            Instantiate<GameObject>(prefabExplosion,
                transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Destroy when leave game
    /// </summary>
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    #endregion
}
