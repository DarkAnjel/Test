using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        Data.prefabCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Data.prefabCount<=0)
        {
            AddPreabs();
        }
    }
    public void AddPreabs()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject temp = PoolManager.instance.GetObject();
            temp.transform.position = GetRandomPos(-12, 12, -2, 2);
            temp.SetActive(true);
            Data.prefabCount++;
        }
    }
    public Vector3 GetRandomPos(int minX,int maxX,int minZ,int maxZ)
    {
        Vector3 temp = new Vector3(Random.Range(minX, maxX), 1, Random.Range(minZ, maxZ));
        return temp;
    }
}
