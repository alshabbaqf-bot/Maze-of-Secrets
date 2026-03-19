using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.AddScore();
            Destroy(gameObject);
        }
    }
}
