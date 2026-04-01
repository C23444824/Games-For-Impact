using UnityEngine;
using TMPro;

public class ItemText : MonoBehaviour
{
    public TextMeshProUGUI item1Text;
    public GameObject inventoryTracker;
    void Update()
    {
        item1Text.text = $"Beans: ({inventoryTracker.GetComponent<InventoryManager>().itemList.item4Quantity})";
    }
}
