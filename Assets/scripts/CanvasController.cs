using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{
    public static CanvasController instance;
    private void Awake()
    {
        instance = this;
    }
    

    public TextMeshProUGUI MoneyText;
    
}
