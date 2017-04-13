using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GUIController : MonoBehaviour
{

    public GameObject button1;
    public GameObject button2;
    public GameObject dialogueText;
    public GameObject canvas;
    public List<string> dialogue = new List<string>();
    public List<string> buttonDialogue = new List<string>();

    public int counter = 0;

    void Start ()
    {

        UpdateGui();
	
	}

    public void UpdateGui()
    {

        // de text aanpassen per nieuw bericht.

        dialogueText.GetComponent<Text>().text = dialogue[counter];

        if(counter == 0)
        {

            button1.GetComponent<Text>().text = buttonDialogue[0];
            button2.GetComponent<Text>().text = buttonDialogue[1];

        } else if (counter == 6)
        {

            button1.GetComponent<Text>().text = buttonDialogue[2];
            button2.GetComponent<Text>().text = buttonDialogue[3];

        } else
        {

            button1.GetComponent<Text>().text = ("");
            button2.GetComponent<Text>().text = ("");

        }

    }

    public void Button1Click()

    // de counter aanpassen zodat het gesprek op het gewenste pad blijft.

    {
        if (counter == 0 || counter == 6)
        {

            counter++;

        } else if(counter == 4 || counter == 5 || counter == 9 || counter == 10)
        {

            counter++;

        } else if(counter == 1 || counter == 2 || counter == 3 || counter == 7 || counter == 8)
        {

            counter += 2;

        } else if (counter == 11)
        {

            canvas.transform.GetComponent<Canvas>().enabled = false;
            counter++;

        }

        UpdateGui();
        

    }

    public void Button2Click()

    // de counter aanpassen zodat het gesprek op het gewenste pad blijft.

    {
        if (counter == 0 || counter == 6)
        {

            counter += 2;

        } else if (counter == 4 || counter == 5 || counter == 9 || counter == 10)
        {

            counter++;

        } else if (counter == 1 || counter == 2 || counter == 3 || counter == 7 || counter == 8)
        {

            counter += 2;

        } else if (counter == 11)
        {

            canvas.transform.GetComponent<Canvas>().enabled = false;
            counter++;

        }

        UpdateGui();

    }

    public void OnTriggerEnter(Collider coll)
    {

        if(coll.transform.tag == "Player" && counter == 0)
        {
            //player controller uitzetten als de speler binnen de collider komt
            coll.transform.GetComponent<CarakterController>().enabled = false;
            coll.transform.GetComponentInChildren<CamMouse>().enabled = false;
            canvas.GetComponent<Canvas>().enabled = true;

        }

    }

    public void OnTriggerStay(Collider coll)
    {

        if (counter == 12)
        {

            //player controller weer aan zetten op het moment dat het gesprek voor bij is.

            coll.transform.GetComponent<CarakterController>().enabled = true;
            coll.transform.GetComponentInChildren<CamMouse>().enabled = true;

        }

    }
}
