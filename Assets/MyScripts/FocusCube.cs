
using UnityEngine;

public class FocusCube : MonoBehaviour
{
    public Interactable focus;

    //If your GameObject starts to collide with another GameObject with a Collider
    void OnCollisionEnter(Collision collision)
    {
        Interactable other = collision.collider.GetComponent<Interactable>();
        if (other != null)
        {
            focus = other;
        }
    }

    void OnCollisionExit (Collision collision)
    {
        focus = null;
    }

    public Interactable GetInteractable()
    {
        return focus;
    }
}