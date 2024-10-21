using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private List<GameObject> pool = new List<GameObject>();

    [SerializeField] private int poolSize = 300;
    [SerializeField] private GameObject prefab;

    public Dictionary<string, List<GameObject>> pools;
    
    
    private void Start()
    {
        CreatePool("Monster");
    }
    
    
    private void CreatePool(string key)
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab, this.transform);
            obj.SetActive(false);
            pool.Add(obj);
        }
        
        pools.Add(key,pool);
    }

    public GameObject Get(string key)
    {
        foreach (var obj in pools[key])
        {
            if (obj.activeSelf)
                return obj;
        }

        return null;
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false);
    }
}