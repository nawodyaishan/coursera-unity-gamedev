using UnityEngine;

/// <summary>
/// Resizes the game object
/// </summary>
public class Resizer : MonoBehaviour
{
    // timer support
    private const float TotalResizeSeconds = 1;
    private float _elapsedResizeSeconds;

    // resizing control
    private const float ScaleFactorPerSecond = 1;
    private int _scaleFactorSignMultiplier = 1;


    /// <summary>
    /// Update is called once per frame
    /// </summary>
    private void Update()
    {
        // resize the game object
        var transform1 = transform;
        Vector2 newScale = transform1.localScale;
        newScale.x += _scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        newScale.y += _scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform1.localScale = newScale;

        // update timer and check if it's done
        _elapsedResizeSeconds += Time.deltaTime;
        if (_elapsedResizeSeconds >= TotalResizeSeconds)
        {
            // reset timer and start resizing the game object
            // in the opposite direction
            _elapsedResizeSeconds = 0;
            _scaleFactorSignMultiplier *= -1;
        }
    }
}