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
        void Start()
        {
            source = GetComponent<AudioSource>();
        }

        public void OnButtonDown(Hand fromHand)
        {
            source.PlayOneShot(nota, 0.5f);
        }

        public void OnButtonUp(Hand fromHand)
        {

        }

    }
}