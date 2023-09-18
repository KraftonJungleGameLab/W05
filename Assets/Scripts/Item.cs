using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    #region PublicVariables
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

#endregion

#region PrivateVariables

#endregion

#region PublicMethods

#endregion

#region PrivateMethods
    void Start()
    {
        
    }
    void Update()
    {
        
    }
#endregion
}
