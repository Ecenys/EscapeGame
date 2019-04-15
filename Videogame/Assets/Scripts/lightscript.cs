using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightscript : MonoBehaviour
{
	
	public GameObject activate;
	
	public bool seq1;
	public bool seq2;
	public bool seq3;
	public bool seq4;
	
	private float time;
	private float frecuency;
    // Start is called before the first frame update
    void Start()
    {
		time = Time.deltaTime;
		frecuency = 0;
    }

    // Update is called once per frame
    void Update()
    {
		frecuency += Time.deltaTime;
        if (activate.transform.position.y < -1.0f){
			if(frecuency<=1)
				if (seq1)
					ColorSelf(Color.red);
				else 
					ColorSelf(Color.black);
			//yield return new WaitForSeconds(1);
			if(1<frecuency && frecuency<=2){
				if (seq2)
					ColorSelf(Color.red);
				else 
					ColorSelf(Color.black);
			}
			//yield return new WaitForSeconds(1);
			if(2<frecuency && frecuency<=3){
				if (seq3)
					ColorSelf(Color.red);
				else 
					ColorSelf(Color.black);
			}
			//yield return new WaitForSeconds(1);
			if(3<frecuency && frecuency<=4){
				if (seq4)
					ColorSelf(Color.red);
				else 
					ColorSelf(Color.black);
			}
			//yield return new WaitForSeconds(1);
			if(4<frecuency && frecuency<=4.5f) ColorSelf(Color.red);
			//yield return new WaitForSeconds(0.005F);
			if(4.5f<frecuency && frecuency<=5)ColorSelf(Color.black);
			//yield return new WaitForSeconds(0.005F);
			if(5<frecuency && frecuency<=5.5)ColorSelf(Color.red);
			//yield return new WaitForSeconds(0.005F);
			if(5.5<frecuency && frecuency<=6)ColorSelf(Color.black);
			//yield return new WaitForSeconds(0.005F);
			if(6<frecuency && frecuency<=6.5)ColorSelf(Color.red);
			//yield return new WaitForSeconds(0.005F);
			if(6.5<frecuency && frecuency<=7)ColorSelf(Color.black);
			if(7<frecuency) frecuency=0;
		}
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
