using System;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
            }
            return instance;
        }

        private set { instance = value; }
    }

    private void Awake()
    {
        if(instance != null)
            Destroy(this.gameObject);
    }
}