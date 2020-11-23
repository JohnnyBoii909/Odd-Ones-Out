using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Items[] itemList=new Items[5];
    public List<InventorySlot> inventorySlots = new List<InventorySlot>();
    public GamestateTracker gamestate;


    public bool AddItem(Items item) 
    {
        for(int i = 0; i < itemList.Length; i++)
        {
            if (itemList[i] ==null)
            {
                itemList[i]= item;
                inventorySlots[i].item =item;
                return true;
            }
        }
        return false;
    }

    public void UpdateSlotUI()
    {
        for(int i = 0; i <inventorySlots.Count; i++)
        {
            inventorySlots[i].UpdateSlot();
        }
    }

    
    public void AddNewItem(Items item)
    {
        bool hasAdded = AddItem(item);

        if (hasAdded)
        {
            UpdateSlotUI();
        }
    }
    /*
    public void updateUI()
    {
        if (gamestate.Gamestep = 3)
        {
            
        }
    }*/
}

 