using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    private TextMeshProUGUI itemText;
    // Start is called before the first frame update
    void Start()
    {
        itemText = GetComponent<TextMeshProUGUI>();
    }

    public void updateItemText(PlayerInventory PlayerInventory)
    {
        itemText.text = PlayerInventory.NumberOfItems.ToString();
    }

}
