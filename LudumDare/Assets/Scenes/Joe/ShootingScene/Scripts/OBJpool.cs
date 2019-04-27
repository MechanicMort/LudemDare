using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJpool : MonoBehaviour
{
    //singleton
    public static OBJpool objectInstance;

    public List<GameObject> thePool;

    public GameObject itemToPool;

    public int amountToPool;



    private void Awake()
    {
        objectInstance = this;
    }


    void Start()
    {
        thePool = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject tempOBJ = Instantiate(itemToPool) as GameObject;
            tempOBJ.SetActive(false);
            thePool.Add(tempOBJ);
        }
    }


    public GameObject GetPooledOBJ()
    {
        for (int i = 0; i < thePool.Count; i++)
        {
            if (!thePool[i].activeInHierarchy)
            {
                return thePool[i];
            }

        }
        return null;
    }
}
