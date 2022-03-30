using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the player
/// </summary>
public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //GetComponent<Rigidbody>().velocity = transform.forward * speed;
        /*Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(1, 0),
            ForceMode2D.Impulse);
        */

        const float minImpulseForce = 3f;
        const float maxImpulseForce = 5f;
        
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minImpulseForce, maxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude,
            ForceMode2D.Impulse);
    }
    
    // Called on a Collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!!!");
    }
}