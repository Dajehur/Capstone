using UnityEngine;

public class PlayerHazardCollision : MonoBehaviour
{
    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Hazard hazard = hit.collider.GetComponentInParent<Hazard>();

        if (hazard != null)
        {
            playerHealth.TakeDamage(hazard.damageAmount);
        }
    }
}