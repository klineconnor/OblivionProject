using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue1 : MonoBehaviour {

    DialogueManager diaMan;
	public GameObject diaBox;

	void Start () {
        diaMan = DialogueManager.Instance;
	}
	
	// Update is called once per frame
	public void Quest()
    {
        diaMan.dialogueText.text = "I don't have any Quests";
    }

    public void Barter()
    {
        diaMan.dialogueText.text = "I don't have any to trade with.";
    }
    
    public void Quit()
    {
		DialogueManager.Instance.EndTalking ();
		Destroy (diaBox);
    }
}
