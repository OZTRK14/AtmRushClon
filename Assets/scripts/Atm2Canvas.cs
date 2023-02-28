using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Atm2Canvas : MonoBehaviour
{
    public static Atm2Canvas instance;
    private void Awake()
    {
        instance = this;

    }
    public TextMeshProUGUI Atm2Text;

}
