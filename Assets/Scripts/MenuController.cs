using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public int activeCategory = 0;
    public Text itemDescription;
    public GameObject[] itemObjects;
    public Sprite[] itemSprites;

    public struct MenuItem
    {
        public int id;
        public string name;
        public string itemDesc;
        public int itemCategory;
        public int IconImage;
    }

    public List<MenuItem> menuI_c1;
    public List<MenuItem> menuI_c2;
    public List<MenuItem> menuI_c3;

    // Use this for initialization
    void Start () {


        Sprite[] _sprites = Resources.LoadAll<Sprite>("");

        List<MenuItem> menuIitems_cat1 = new List<MenuItem>();
        List<MenuItem> menuIitems_cat2 = new List<MenuItem>();
        List<MenuItem> menuIitems_cat3 = new List<MenuItem>();


        menuIitems_cat1.Add(new MenuItem { id = 1, name = "Item #1", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 0 });
        menuIitems_cat1.Add(new MenuItem { id = 2, name = "Item #2", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 1 });
        menuIitems_cat1.Add(new MenuItem { id = 3, name = "Item #3", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 2 });
        menuIitems_cat1.Add(new MenuItem { id = 4, name = "Item #4", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 3 });
        menuIitems_cat1.Add(new MenuItem { id = 4, name = "Item #5", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 4 });

        menuIitems_cat2.Add(new MenuItem { id = 0, name = "Item #6", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 0 });
        menuIitems_cat2.Add(new MenuItem { id = 1, name = "Item #7", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 1 });
        menuIitems_cat2.Add(new MenuItem { id = 2, name = "Item #8", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 2 });
        menuIitems_cat2.Add(new MenuItem { id = 3, name = "Item #9", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 3 });
        menuIitems_cat2.Add(new MenuItem { id = 4, name = "Item #10", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 4 });

        menuIitems_cat3.Add(new MenuItem { id = 0, name = "Item #11", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 0 });
        menuIitems_cat3.Add(new MenuItem { id = 1, name = "Item #12", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 1 });
        menuIitems_cat3.Add(new MenuItem { id = 2, name = "Item #13", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 2 });
        menuIitems_cat3.Add(new MenuItem { id = 3, name = "Item #14", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 3 });
        menuIitems_cat3.Add(new MenuItem { id = 4, name = "Item #15", itemDesc = "This is an amazing item mothafuckar", itemCategory = 0, IconImage = 4 });

        menuI_c1 = menuIitems_cat1;
        menuI_c2 = menuIitems_cat2;
        menuI_c3 = menuIitems_cat3;
    }
	
	// Update is called once per frame
	void Update () {


        if(activeCategory == 0){
            for (int i = 0; i < itemObjects.Length; i++)
            {
                itemObjects[i].GetComponentInChildren<Text>().text = menuI_c1[i].name;
                itemObjects[i].GetComponentInChildren<Image>().sprite = itemSprites[menuI_c1[i].IconImage];
                itemDescription.GetComponent<Text>().text = menuI_c1[i].itemDesc;
            }
        }

        if (activeCategory == 1)
        {
            for (int i = 0; i < itemObjects.Length; i++)
            {
                itemObjects[i].GetComponentInChildren<Text>().text = menuI_c2[i].name;
                itemObjects[i].GetComponentInChildren<Image>().sprite = itemSprites[menuI_c2[i].IconImage];
                itemDescription.GetComponent<Text>().text = menuI_c2[i].itemDesc;
            }
        }

        if (activeCategory == 2)
        {
            for (int i = 0; i < itemObjects.Length; i++)
            {
                itemObjects[i].GetComponentInChildren<Text>().text = menuI_c3[i].name;
                itemObjects[i].GetComponentInChildren<Image>().sprite = itemSprites[menuI_c3[i].IconImage];
                itemDescription.GetComponent<Text>().text = menuI_c3[i].itemDesc;
            }
        }
    }
}
