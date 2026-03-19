using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameManager.HasAllCoins())
            {
                gameManager.WinGame();
            }
        }
    }
}
