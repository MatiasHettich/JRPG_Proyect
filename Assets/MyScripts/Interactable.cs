using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public float offset_x = 0f;
    public float offset_y = 0f;
    public float offset_z = 0f;

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position + new Vector3(offset_x, offset_y, offset_z), radius);
    }
}
