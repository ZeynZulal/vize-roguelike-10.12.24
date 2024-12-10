using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text healthText;

    public void UpdateHealth(int currentHealth)
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }
}


