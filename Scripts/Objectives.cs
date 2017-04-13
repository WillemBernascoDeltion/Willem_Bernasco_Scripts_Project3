using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectives : MonoBehaviour
{

    public List<string> objectives = new List<string>();
    public Text keyText;
    public Text objectiveText;
    public GameObject key;
    private bool moveGate;
    public GameObject door;
    public GameObject secondCamera;

    private int i;
    private float time = 4f;

    void Update()
    {
        objectiveText.text = "Wat te doen: " + objectives[i]; //dit zorgt ervoor dat op het scherm de objective word geprint via de UI tekst van de canvas

        if (i == 1) // i staat gelijk aan de sleutels die je hebt opgepakt en zodra je de sleutel hebt opgepakt word 'cutscene' in werking gezet
        {
            Cutscene();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
            //als je de sleutel oppakt gaat de deur open
        {
            keyText.text = "Sleutel: " + 1 + " van de 1";
            Destroy(key);
            door.transform.GetComponent<PoortController>().OpenGate();
            i++;
        }
    }

    private void Cutscene()
    {
        // dit zorgt ervoor dat de juiste camera word geactiveerd tijdens de cutscene
        time -= 1 * Time.deltaTime;

        if(time >= 0)
        {

            secondCamera.transform.GetComponent<Camera>().enabled = true;

        } else
        {

            secondCamera.transform.GetComponent<Camera>().enabled = false;

        }

    }
}
