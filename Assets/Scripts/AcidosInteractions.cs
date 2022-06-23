using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidosInteractions : MonoBehaviour
{
    public AudioClip grabbedSound;
    public void PlayGrabbedSound() {
        GetComponent<AudioSource>().PlayOneShot(grabbedSound);
    }
}
