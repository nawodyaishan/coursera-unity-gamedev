using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gets the attached game object moving
/// </summary>
public class Mover : MonoBehaviour
{
	/// <summary>
	/// Start is called before the first frame update
	/// </summary>
	void Start()
	{
        // get the game object moving
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(0, 5),
            ForceMode2D.Impulse);		
	}
}
