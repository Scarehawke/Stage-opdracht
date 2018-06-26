using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class BuyScript : VRTK_InteractableObject
{

    public GameObject uiObject;
    public int itemIndex;
    public GameObject spawnPoint;
    public GameObject menuObject;

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);

        MenuController menu = uiObject.GetComponent<MenuController>();

        if (menu.currentSelectedItem < 0)
            return;

        var spawnedObject = Instantiate(menu.itemPrevObjects[menu.menuI_c1[menu.currentSelectedItem].IconImage], spawnPoint.gameObject.transform.localPosition, Quaternion.identity);
        //spawnedObject.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);
        spawnedObject.transform.localPosition = spawnPoint.transform.localPosition;
        spawnedObject.transform.position = spawnPoint.transform.position;


        spawnedObject.gameObject.AddComponent<Rigidbody>();

    }

    public override void StopUsing(VRTK_InteractUse usingObject)
    {
        base.StopUsing(usingObject);
    }

    protected void Start()
    {

    }

    protected override void Update()
    {
        base.Update();
    }
}
