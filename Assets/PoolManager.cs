using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;
    GameObject prefab;
    [SerializeField]
    int poolNum;
    List<GameObject> poolList = new List<GameObject>();
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        prefab = Resources.Load<GameObject>("Prefab");
        for (int i = 0; i < poolNum; i++)
        {
            GameObject temp = Instantiate(prefab);
            temp.SetActive(false);
            poolList.Add(temp);
        }
    }

    // Update is called once per frame
   public GameObject GetObject()
    {
        GameObject temp=null;
        for (int i = 0; i < poolList.Count; i++)
        {

            if(!poolList[i].activeInHierarchy)
            {
                temp = poolList[i];
            }
        }
        return temp;
    }

}
