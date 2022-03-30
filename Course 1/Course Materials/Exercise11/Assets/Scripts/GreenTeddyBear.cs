using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Triples the height of the green teddy bear
/// </summary>
public class GreenTeddyBear : MonoBehaviour
{
	/// <summary>
	/// Start is called before the first frame update
	/// </summary>
	void Start()
	{
        // triple height
        Vector3 newScale = transform.localScale;
        newScale.y *= 3;
        transform.localScale = newScale;
	}
}
