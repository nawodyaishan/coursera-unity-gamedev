using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A rock spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField]
    GameObject prefabRock;

    // saved for efficiency
    [SerializeField]
    Sprite greenRockSprite;
    [SerializeField]
    Sprite magentaRockSprite;
    [SerializeField]
    Sprite whiteRockSprite;

    // spawn control
    const float SpawnDelaySeconds = 1;
    Timer spawnTimer;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = SpawnDelaySeconds;
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // check for time to spawn a new rock
        if (spawnTimer.Finished &&
            GameObject.FindGameObjectsWithTag("Rock").Length < 3)
        {
            SpawnRock();

            // restart spawn timer
            spawnTimer.Run();
        }
    }

    /// <summary>
    /// Spawns a new rock at the center of the window 
    /// </summary>
    void SpawnRock()
    {
        // create new rock
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = Vector3.zero;

        // set random sprite for new rock
        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = greenRockSprite;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = magentaRockSprite;
        }
        else
        {
            spriteRenderer.sprite = whiteRockSprite;
        }
    }
}
