//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class Nota : MonoBehaviour
    {
        public AudioSource source;
        public AudioClip nota;
        public GameObject cubo;

        void Start()
        {
            source = GetComponent<AudioSource>();
        }

        public void OnButtonDown(Hand fromHand)
        {
            if (this.name == "Cube")
            {
                if (source.isPlaying) { }
                else
                {
                    source.Play();
                }
            }
            else
            {
                source.Play();
                cubo.GetComponent<Pianito>().input.Add(Int32.Parse(this.name)); 
            }
        }

        public void OnButtonUp(Hand fromHand)
        {

        }

    }
}