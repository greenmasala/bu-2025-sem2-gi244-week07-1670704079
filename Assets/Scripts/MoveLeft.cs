using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    PlayerController Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Player = FindFirstObjectByType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Player.isGameOver)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        if (transform.position.x < -13)
        {
            Destroy(gameObject);
        }
    }
}
