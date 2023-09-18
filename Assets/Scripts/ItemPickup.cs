using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    #region PublicVariables
    public Item item;
    #endregion

    #region PrivateVariables

    #endregion

    #region PublicMethods
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }
    #endregion

    #region PrivateMethods
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }

    }
#endregion
}
