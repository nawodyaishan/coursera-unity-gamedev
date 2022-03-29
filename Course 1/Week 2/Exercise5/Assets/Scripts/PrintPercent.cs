using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exercise 5 Solution
/// </summary>
public class PrintPercent : MonoBehaviour
{
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
	{
        // set values
        const int MaxScore = 100;
        int score = 50;

        // calculate and print percent
        float percent = ((float)score / MaxScore) * 100;
        print("Percent: " + percent + "%");
    }
}
