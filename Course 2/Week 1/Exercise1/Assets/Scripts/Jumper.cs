using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    /// <summary>
    /// Jumper class 
    /// </summary>
    // Start is called before the first frame update
    
    // Jump Location Support
        const float minX = -8f;
        const float maxX = 8f;
        const float minY = -4f;
        const float maxY = 4f;
        
        // Timer Support
        
        const float TotalJumpDelaySeconds = 1f;
        
        float elapsedJumpDelaySeconds = 0f;
        
        // Update Timer and Check if its done
        void Update()
    {
        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0f;
            Vector3 position = transform.position;
            position.x = Random.Range(minX, maxX);
            position.y = Random.Range(minY, maxY);
            transform.position = position;
        }

    }
}