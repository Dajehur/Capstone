using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Transform currentCheckpoint;
    private CharacterController characterController;
    private PlayerHealth playerHealth;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerHealth = GetComponent<PlayerHealth>();
    }

    public void SetCheckpoint(Transform checkpoint)
    {
        currentCheckpoint = checkpoint;
    }

    public void FallIntoWater()
    {
        playerHealth.TakeDamage(1);

        if (currentCheckpoint != null)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        characterController.enabled = false;

        transform.position = currentCheckpoint.position;
        transform.rotation = currentCheckpoint.rotation;

        characterController.enabled = true;
    }
}