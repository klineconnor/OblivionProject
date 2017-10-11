using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : interactible
{
    public string NPCName;
    public string StartingText;
	public GameObject dialogueOptions;
    

    public override void Interact()
    {
		DialogueManager.Instance.StartTalking (NPCName, StartingText, dialogueOptions);
    }
}
