using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestData", menuName = "Scriptable Object/QuestData", order = 0)]
public abstract class QusetDataSO : ScriptableObject
{
    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public List<int> QuestPrerequisites;
    
    public string GetQuestInfo()
    {
        return $"{QuestName}(최소 레벨 {QuestRequiredLevel})\n{QuestInfo()}";  // 추가정보를 다음 줄 출력 
    }

    
    protected abstract string QuestInfo();
}