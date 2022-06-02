using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Newton (the guy or the cookie)
/// </summary>
public class Newton : MonoBehaviour
{
    const float MoveUnitsPerSecond = 10;
    int health = 0;
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// move as appropriate
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            Vector2 position = transform.position;
            position.x += horizontalInput * MoveUnitsPerSecond *
                Time.deltaTime;
            transform.position = position;
        }
	}

    /// <summary>
    /// Gains health and destroys apple
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        Apple apple = coll.gameObject.GetComponent<Apple>();
        if (apple != null)
        {
            health += apple.Health;
            print("New health: " + health);
            Destroy(coll.gameObject);
        }
    }
}
