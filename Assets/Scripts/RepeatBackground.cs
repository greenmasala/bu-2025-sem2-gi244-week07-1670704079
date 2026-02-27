using Unity.VisualScripting;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float bgWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        bgWidth = GetComponent<BoxCollider>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = startPos.x - transform.position.x;

        if (distance > bgWidth/2) //put in box collider to get size of x, y and z, then divide it by 2
        {
            transform.position = startPos;
        }
    }
}
