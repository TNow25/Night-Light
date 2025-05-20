using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class healthUI : MonoBehaviour
{
    private TextMeshProUGUI healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
    }

    public void updateHealthText(PlayerHealth playerHealth)
    {
        healthText.text = playerHealth.healthCounter.ToString();
    }
}
