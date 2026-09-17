using UnityEngine;

public class TargetPickup : MonoBehaviour
{
    private bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (collected)
            return;

        if (other.CompareTag("Player"))
        {
            collected = true;

            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.TargetCollected();

            gameObject.SetActive(false);
        }
    }
}