using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aceptar : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public void Acepto() {
        gameManager.Aceptar();
    }
}
