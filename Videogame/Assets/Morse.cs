using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class Morse : MonoBehaviour
    {
        public GameObject texto;
        public int contador = 0;
        public String[] textito = new String[26];
        public String[] prueba = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        void Start()
        {
            textito = prueba;
        }

        public void OnButtonDown(Hand fromHand)
        {
            contador++;
            if (contador == 26)
            {
                contador = 0;
            }
            texto.GetComponent<TextMesh>().text = textito[contador];
        }

        public void OnButtonUp(Hand fromHand)
        {
        }

    }
}
