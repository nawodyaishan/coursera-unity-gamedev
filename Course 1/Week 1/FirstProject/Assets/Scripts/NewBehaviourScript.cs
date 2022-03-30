using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // triple height
        var transform1 = transform;
        var newScale = transform1.localScale;
        newScale.y *= 3;
        newScale.x *= 3;
        transform1.localScale = newScale;
    }
}