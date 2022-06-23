using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public void destruir() {

        gameObject.SetActive(false);
    }
    public void Salio() {
        
    }

    public void alumbrar()
    {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
    public void desalumbrar()
    {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
}
