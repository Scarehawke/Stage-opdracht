using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ItemScript : VRTK_InteractableObject
{

    public GameObject uiObject;
    public int itemIndex;
    public GameObject panelItem; 

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);

        panelItem.transform.Translate(0, 0, 0.05f);

        MenuController menu = uiObject.GetComponent<MenuController>();

        // Remove all game objects
        foreach (Transform child in menu.itemPrev.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        Transform t = Instantiate( menu.itemPrevObjects[ menu.menuI_c1[itemIndex].IconImage] ) as Transform;
        t.parent = menu.itemPrev.transform; // group the instance under the spawner
        t.localPosition = Vector3.zero; // make it at the exact position of the spawner
        t.localRotation = Quaternion.identity; // same for rotation
        t.transform.localScale = menu.itemPrev.transform.localScale;
        t.gameObject.name = "Preview Item";


        menu.itemDescription.text = menu.menuI_c1[itemIndex].itemDesc;
    }

    public override void StopUsing(VRTK_InteractUse usingObject)
    {
        base.StopUsing(usingObject);
        panelItem.transform.Translate(0, 0, -0.05f);
    }

    protected void Start()
    {

    }

    protected override void Update()
    {
        base.Update();
    }
}
