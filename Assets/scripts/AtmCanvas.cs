using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AtmCanvas : MonoBehaviour
{
    public static AtmCanvas instance;
    private void Awake()
    {
        instance = this;
    }
    public TextMeshProUGUI AtmText;
   

}
