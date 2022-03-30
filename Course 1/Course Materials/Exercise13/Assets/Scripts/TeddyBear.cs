using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // get the teddy bear moving
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(5, 0),
            ForceMode2D.Impulse);
    }
	
}
