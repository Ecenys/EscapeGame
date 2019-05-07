//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {
		public String number;
		public GameObject marco;
		public GameObject activate;
		
		void Start()
		{
			
		}
		
        public void OnButtonDown(Hand fromHand)
        {
			//if(activate.transform.position.y < -1.0f){
				String text = marco.GetComponent<TextMesh>().text;
				text += number;
				marco.GetComponent<TextMesh>().text = text;
			//}
            //ColorSelf(Color.cyan);
            //fromHand.TriggerHapticPulse(1000);
		}

        public void OnButtonUp(Hand fromHand)
        {
            //ColorSelf(Color.white);
        }
		

        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
    }
}