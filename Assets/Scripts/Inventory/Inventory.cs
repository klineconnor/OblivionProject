using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
#region Singleton
    public static Inventory Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Error more than one inventory instance");
        }
        Instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Item> items;
    public float CurrentWeight;
    public float MaxWeight;

    public void AddItem(Item item)
    {
        items.Add(item);
        CurrentWeight += item.weight;
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

    public bool CheckWeight(Item item)
    {
        if(CurrentWeight + item.weight >= MaxWeight)
        {
            return false;
        } else
        {
            return true;
        }
    }

    public void RemoveItem(Item item)
    {
		Debug.Log ("Removed" + item.name);
        items.Remove(item);
        CurrentWeight -= item.weight;
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
