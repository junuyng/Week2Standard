  using System;
  using UnityEngine;
using UnityEngine.UI;

public class QuestInfoUI : MonoBehaviour
{
    [SerializeField] private Text questInfoText;
    
    private void Start()
    {   
        SetQuestInfoText();
    }

    private void SetQuestInfoText()
    {
        questInfoText.text = QuestManager.Instance.GetQuestsInfo();
    }

}
