using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static PauseMenu Instance;
	public GameObject pauseMenu;
	public GameObject activeMenu;
	public bool isPause;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Error, multiple Pause Menu Managers found");
        }
        Instance = this;
		activeMenu.GetComponent<Animator>().SetBool("Open", true);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
			isPause = !isPause;
			pauseMenu.GetComponent<Animator> ().SetBool ("Open", isPause);
            Cursor.visible = isPause;
            if (isPause)
            {
                CharacterManager.Instance.StopCharacter();
            } else
            {
                CharacterManager.Instance.StartCharacter();
            }

        }
    }

    public void SetMenu(GameObject newMenu)
    {
		activeMenu.GetComponent<Animator> ().SetBool ("Open", false);
        activeMenu = newMenu;
		activeMenu.GetComponent<Animator> ().SetBool ("Open", true);
    }
}
