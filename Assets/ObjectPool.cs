using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// **[구현사항 1]**
//
//     강의에서 스치듯이 본 **오브젝트 풀**을 `List`를 통해 구현하고자 합니다.기본적으로 **300개의 게임오브젝트를 생성**하고, `Get` / `Release`를 구현하세요.
//     (`Get` : 오브젝트 풀에서 비활성인 게임오브젝트를 가져오는 행위, `Release`: 활성중인 게임오브젝트를 비활성으로 두는 행위)

public class ObjectPool : MonoBehaviour
{
    private List<GameObject> pool = new List<GameObject>();
    [SerializeField] private int poolSize = 300;
    [SerializeField] private GameObject prefab;

    private void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab, this.transform);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject Get()
    {
        foreach (var obj in pool)
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