using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroys a C4 Teddy Bear every second
/// </summary>
public class Destroyer : MonoBehaviour
{
    [SerializeField] GameObject prefabExplosion;

    Timer destroyTimer;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    void Start()
    {
        // set up destroy timer
        destroyTimer = gameObject.AddComponent<Timer>();
        destroyTimer.Duration = 1;
        destroyTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>	
    void Update()
    {
        // destroy teddy bear as appropriate
        if (destroyTimer.Finished)
        {
            destroyTimer.Run();

            // find and blow up teddy bear
            GameObject teddyBear = GameObject.FindWithTag("C4TeddyBear");
            if (teddyBear != null)
            {
                Instantiate<GameObject>(prefabExplosion,
                    teddyBear.transform.position, Quaternion.identity);
                Destroy(teddyBear);
            }
        }
    }
}