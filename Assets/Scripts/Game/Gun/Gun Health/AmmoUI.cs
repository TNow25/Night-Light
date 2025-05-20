using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoUI : MonoBehaviour
{
    private TextMeshProUGUI ammoText;
    // Start is called before the first frame update
    void Start()
    {
        ammoText = GetComponent<TextMeshProUGUI>();
    }

    public void updateItemText(PlayerAmmo playerAmmo)
    {
        ammoText.text = playerAmmo.ammoCounter.ToString();
    }

    

}
