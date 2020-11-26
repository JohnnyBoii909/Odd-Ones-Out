using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrade : MonoBehaviour
{
    public List<Items> itemProgress;

    public int maxItems = 2;

    public bool haveItem(Items Item)
    {
        itemProgress.Add(Item);
        print(itemProgress.Count);
        return true;
    }

}
