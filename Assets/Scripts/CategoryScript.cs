using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CategoryScript : VRTK_InteractableObject
{

    public int catInt;
    public GameObject uiObject;

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);

        //Set main category to this catInt
        uiObject.GetComponent<MenuController>().activeCategory = catInt;
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
