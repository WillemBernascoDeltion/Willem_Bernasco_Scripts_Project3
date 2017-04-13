using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoortController : MonoBehaviour
{

    Animator anim;


	void Start () {

        anim = GetComponent<Animator>(); 
		
	}
	


    public void OpenGate()
    {
        //dit activeerd de trigger die de 'PoortOpen' animatie activeerd
        anim.SetTrigger("Sleutel");

    }
}
