using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
    PlayerController player;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, Random.Range(2f, 4f));
    }

    void Spawn()
    {
        GameObject playerObj = GameObject.Find("Player");
        PlayerController player = playerObj.GetComponent<PlayerController>();
        if (player.isGameOver)
        {
            return;
        }

        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
