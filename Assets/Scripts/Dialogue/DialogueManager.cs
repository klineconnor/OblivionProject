using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Error: There is more than one Dialogue Manager");
        }
        Instance = this;
    }

	public Text nameText;
    public Text dialogueText;
	public DialogueBox dialogueBox;
	public bool isTalking = false;

	public void StartTalking(string NPCName, string StartingText, GameObject dialogueOptions)
	{
		if (isTalking == false)
		{
			isTalking = true;
			nameText.text = NPCName;
			dialogueText.text = StartingText;
			CharacterManager.Instance.StopCharacter();
			dialogueBox.Open();
			Instantiate(dialogueOptions, dialogueBox.transform);
		}
	}

	public void EndTalking()
	{
		dialogueBox.Close ();
		isTalking = false;
		GetComponent<CharacterManager> ().StartCharacter ();
	}
}
