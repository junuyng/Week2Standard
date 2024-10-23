using System;
using System.Linq;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    [SerializeField] private QusetDataSO[] Quests;


    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();

                if (instance == null)
                {
                    GameObject QuestManager = new GameObject("QuestManager");
                    instance = QuestManager.AddComponent<QuestManager>();
                }
            }

            return instance;
        }

        private set { instance = value; }
    }


    private void Awake()
    {
        if (instance != null)
            Destroy(this.gameObject);
    }


    private void Start()
    {
        foreach (var quset in Quests)
        {
            quset.GetQuestInfo();
        }
    }


    public string GetQuestsInfo()
    {
        if (Quests.Length == 0 || Quests == null)
            return "퀘스트가 존재하지 않습니다.";

        string QuestsInfo = "";

        for (int i = 0; i < Quests.Length; i++)
        {
            QuestsInfo = QuestsInfo + $"Quest {i + 1} - {Quests[i].GetQuestInfo()}\n";
        }

        return QuestsInfo;
    }
}