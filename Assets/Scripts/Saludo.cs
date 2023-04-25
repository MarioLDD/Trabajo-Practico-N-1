using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Saludo : MonoBehaviour
{
    public TMP_Text saludoText;
    public void MuestroSaludo(string saludo)
    {
    saludoText.text = saludo;
    }
}
