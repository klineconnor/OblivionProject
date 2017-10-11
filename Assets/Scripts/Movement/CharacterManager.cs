using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    public static CharacterManager Instance;
    public string CharacterName;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Error more than one Character Manager");
        }
        Instance = this;
    }

    public GameObject character;

    public void StopCharacter()
    {
		Cursor.visible = true;
        character.GetComponent<CharMove>().enabled = false;
    }

    public void StartCharacter()
    {
		Cursor.visible = false;
        character.GetComponent<CharMove>().enabled = true;
    }
}
