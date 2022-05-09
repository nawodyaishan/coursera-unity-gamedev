using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script to test the timer class
/// </summary>
public class TimerTest : MonoBehaviour
{
	// test object
	Timer timer;

	// time measurement
	float startTime;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
		// create and run timer
		timer = gameObject.AddComponent<Timer>();
		timer.Duration = 3;
		timer.Run ();

		// save start time
		startTime = Time.time;
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// check for timer just finished
		if (timer.Finished)
        {
			float elapsedTime = Time.time - startTime;
			Debug.Log("Timer ran for " + elapsedTime + " seconds");

			// save start time and restart timer
			startTime = Time.time;
			timer.Run();
		}
	}
}
