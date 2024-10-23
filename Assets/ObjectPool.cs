using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private int poolSize = 300;
    [SerializeField] private GameObject[] prefabs;

    public Dictionary<string, List<GameObject>> pools = new Dictionary<string, List<GameObject>>();


    private void Start()
    {
        CreatePool("Monster", prefabs[0]);
    }
    

    private void CreatePoolsByPrefabName()
    {
        List<GameObject> pool = new List<GameObject>();
        
        for (int i = 0; i < prefabs.Length; i++)
        {
            GameObject prefab = prefabs[i];

            for (int j = 0; j < poolSize; j++)
            {
                GameObject obj = Instantiate(prefab, this.transform);
                obj.SetActive(false);
                pool.Add(obj);
            }
            
            pools.Add(prefab.name, pool);
        }
    }

    
    //pool을 사용해보는 로직 만들기 ? button 통해서 한번 사용해보도록 
    
    private void CreatePool(string key, GameObject prefab)
    {
        List<GameObject> pool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab, this.transform);
            obj.SetActive(false);
            pool.Add(obj);
        }

        pools.Add(key, pool);
    }

    public GameObject Get(string key)
    {
        if (!pools.ContainsKey(key))
            return null;

        foreach (var obj in pools[key])
        {
            if (!obj.activeSelf)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        return null;
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false);
    }
}