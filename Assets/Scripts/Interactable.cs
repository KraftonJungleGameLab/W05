using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    #region PublicVariables
    public float radius = 3f;
    public Transform interactionTransform;
#endregion

#region PrivateVariables
   private bool isFocus = false;
    private Transform player;
#endregion

#region PublicMethods
    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + interactionTransform.name);
    }
#endregion

#region PrivateMethods
    void Start()
    {
        
    }
    void Update()
    {
        if (isFocus)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if (distance <= radius)
            {
                Debug.Log("INTERACT");
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(interactionTransform.parent != null)
        {
            interactionTransform = transform;
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
    #endregion
}
