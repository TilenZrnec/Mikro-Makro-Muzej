using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.score++;
            Debug.Log("Score: " + GameManager.score);

            Destroy(gameObject);
        }
    }
}
