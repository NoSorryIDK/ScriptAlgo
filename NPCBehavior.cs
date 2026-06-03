using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    // NPC health
    public int health = 5;
    // NPC level
    public int level = 1;
    // NPC speed
    public float speed = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // adds level no. to health
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
