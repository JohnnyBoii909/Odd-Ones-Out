using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Items item;
    public GameObject icon;

    public void UpdateSlot()
    {
        if(item != null)
        {
            icon.GetComponent<Image>().sprite = item.icon;
            icon.SetActive(true);
        }
        else
        {
            icon.SetActive(false);
        }
    }

}
