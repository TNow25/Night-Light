using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoCount : MonoBehaviour
{
    private TextMeshProUGUI ammoText;
    // Start is called before the first frame update
    void Start()
    {
        ammoText = GetComponent<TextMeshProUGUI>();
    }

    public void updateAmmoText(Gun gun)
    {
        ammoText.text = gun.gunData.currentAmmo.ToString();
    }
}

