using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour {
    
        public void OnTriggerEnter(Collider coll) //Als je in contact komt voert hij de volgende actie uit.
    {
        if (coll.transform.tag == "Einde")
        {
            SceneManager.LoadScene("Scene3Einde");//Laad de volgende scene
        }
    }
}

