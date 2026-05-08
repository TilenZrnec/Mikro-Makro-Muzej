using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float floatSpeed = 2f;
    public float floatHeight = 0.3f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // rotation
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // up & down movement
        float newY = Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = startPos + new Vector3(0, newY, 0);
    }
}