using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public int activeCategory = 0;
    public Text itemDescription;
    public GameObject[] itemObjects;
    public Sprite[] itemSprites;
    public GameObject itemPrev;
    public Transform[] itemPrevObjects;

    public struct MenuItem
    {
        public int id;
        public string name;
        public string itemDesc;
        public int IconImage;
        public int SpriteId;
    }

    public List<MenuItem> menuI_c1;

    // Use this for initialization
    void Start()
    {

        List<MenuItem> menuIitems = new List<MenuItem>();

        menuIitems.Add(new MenuItem { id = 1, name = "PC Fan", itemDesc = "This is a awsome PC FAN\nLoads of derp-derp-derp in this\nthing", IconImage = 0, SpriteId = 0});
        menuIitems.Add(new MenuItem { id = 2, name = "Awsome Cube", itemDesc = "This cube is amazing", IconImage = 1, SpriteId = 1});
        menuIitems.Add(new MenuItem { id = 3, name = "Item #3", itemDesc = "Molre item desc " + Random.Range(0, 100000), IconImage = 0, SpriteId = 2});

        
        menuIitems.Add(new MenuItem { id = 4, name = "Item #4", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 5, name = "Item #5", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });

        menuIitems.Add(new MenuItem { id = 6, name = "Item #6", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 7, name = "Item #7", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 8, name = "Item #8", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 9, name = "Item #9", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 10, name = "Item #10", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });

        menuIitems.Add(new MenuItem { id = 11, name = "Item #11", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 12, name = "Item #12", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 13, name = "Item #13", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 14, name = "Item #14", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        menuIitems.Add(new MenuItem { id = 15, name = "Item #15", itemDesc = "Molre item desc " + Random.Range(0,100000), IconImage = 0, SpriteId = 2 });
        
        menuI_c1 = menuIitems;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeCategory == 0)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(i + " " + menuI_c1.Count);
                if (i <= menuI_c1.Count - 1)
                {
                    itemObjects[count].GetComponentInChildren<Text>().text = menuI_c1[i].name;
                    itemObjects[count].GetComponentInChildren<Image>().sprite = itemSprites[menuI_c1[i].SpriteId];
                    itemObjects[count].GetComponentInChildren<ItemScript>().itemIndex = i;
                    count++;
                }
            }
        }

        if (activeCategory == 1)
        {
            int count = 0;
            for (int i = 5; i < 10; i++)
            {
                if (i <= menuI_c1.Count - 1)
                {
                    itemObjects[count].GetComponentInChildren<Text>().text = menuI_c1[i].name;
                    itemObjects[count].GetComponentInChildren<Image>().sprite = itemSprites[menuI_c1[i].SpriteId];
                    itemObjects[count].GetComponentInChildren<ItemScript>().itemIndex = i;
                    count++;
                }
            }
        }

        if (activeCategory == 2)
        {
            int count = 0;
            for (int i = 10; i < 15; i++)
            {
                if (i <= menuI_c1.Count - 1)
                {
                    itemObjects[count].GetComponentInChildren<Text>().text = menuI_c1[i].name;
                    itemObjects[count].GetComponentInChildren<Image>().sprite = itemSprites[menuI_c1[i].SpriteId];
                    itemObjects[count].GetComponentInChildren<ItemScript>().itemIndex = i;
                    count++;
                }
            }
        }
    }
}
