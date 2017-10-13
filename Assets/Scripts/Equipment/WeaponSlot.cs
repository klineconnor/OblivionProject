using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSlot : MonoBehaviour {

	// Use this for initialization
	Image icon;
	public GameObject RemoveButton;

	void Start()
	{
		RemoveButton.GetComponent<Image>().enabled = false;
		RemoveButton.GetComponent<Button>().interactable = false;
		icon = GetComponent<Image>();
		icon.enabled = false;
	}

	public void SetEquip(Item newEquip)
	{
		RemoveButton.GetComponent<Image>().enabled = true;
		RemoveButton.GetComponent<Button>().interactable = true;
		icon.enabled = true;
		icon.sprite = newEquip.icon;
	}

	public void RemoveEquip()
	{
		RemoveButton.GetComponent<Image>().enabled = false;
		RemoveButton.GetComponent<Button>().interactable = false;
		icon.sprite = null;
		icon.enabled = false;	}
}
