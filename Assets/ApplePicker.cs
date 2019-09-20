using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ApplePicker : MonoBehaviour
{

    public GameObject basketPreFab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i = 0; i < numBaskets; i++ )
        {
            GameObject tBasketGO = Instantiate(basketPreFab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AppleDestroyed()
    {
        GameObject[] tAplleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGo in tAplleArray)
        {
            Destroy(tGo);
        }
        //desroy one of the baskets
        //get the index f the last basket in basket list
        int basketIndex = basketList.Count - 1;
        GameObject tbasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tbasketGO);

        if(basketList.Count == 0)
        {
            Application.LoadLevel("Level_1");
        }
                
    }
}
