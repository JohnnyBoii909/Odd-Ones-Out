using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrade : MonoBehaviour
{
    public List<Items> itemProgress;

    public int maxItems = 5;

    public bool haveItem(Items Item)
    {
        itemProgress.Add(Item);
        print(itemProgress.Count);
        return true;
    }

    private void checkProgress()
    {
        if (itemProgress.Count >= maxItems)
        {
            
        }
    }

    

    private void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
