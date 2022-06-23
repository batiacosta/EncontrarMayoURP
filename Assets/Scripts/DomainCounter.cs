using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomainCounter : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "acido") {
            _gameManager.Sumar();
            Destroy(other.gameObject);
        }
    }
}
