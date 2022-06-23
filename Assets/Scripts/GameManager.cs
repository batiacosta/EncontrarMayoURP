using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int recogidos;
    [SerializeField] private int aRecoger;
    [SerializeField] private int[] recogerList;
    [SerializeField] private Material[] rodillaM;
    [SerializeField] private GameObject rodilla;
    [SerializeField] private GameObject rodillaCompleta;
    [SerializeField] private GameObject[] pantallas;
    [SerializeField] private AudioClip[] sonidos;

    [SerializeField] private TextMeshPro counterT;

    private void Update()
    {
        counterT.text = recogidos + " / " + aRecoger + " mg";
    }

    private void Awake()
    {
        rodillaCompleta.GetComponent<Animator>().SetBool("isHealthy", false);
        Pantalla1();
        MaterialRodilla(0);
    }

    void Pantalla1() {
        pantallas[0].gameObject.SetActive(true);
        pantallas[1].gameObject.SetActive(false);
    }

    public void Aceptar() {
        pantallas[0].gameObject.SetActive(false);
        Destroy(GameObject.Find("AceptarB"));
    }

    public void Pantalla2() {
        pantallas[1].gameObject.SetActive(true);
        pantallas[0].gameObject.SetActive(false);
    }

    public void Sumar() {
        recogidos++;
        SetCounterText(recogidos*6 + " / " + aRecoger*6 + " mg/3ml");
        if (recogidos == 4)
        {
            SetCounterText("24mg/3ml");
            Pantalla2();
            rodillaCompleta.GetComponent<Animator>().SetBool("isHealthy", true);
            GetComponent<AudioSource>().PlayOneShot(sonidos[1]);
        }
        else {
            GetComponent<AudioSource>().PlayOneShot(sonidos[0]);
        }
        MaterialRodilla(recogidos);
    }

    void SetCounterText(string contenido) {
        counterT.text = contenido;
    }

    void MaterialRodilla(int i) {
        rodilla.GetComponent<Renderer>().material = rodillaM[i];
    }
}
