using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestData", menuName = "Scriptable Object/QuestData", order = 0)]
public class QusetDataSO : ScriptableObject
{
    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public List<int> QuestPrerequisites;
    
    public virtual string GetQuestInfo()
    {
        return $"{QuestName}(최소 레벨 {QuestRequiredLevel})";
    }
    
    
    
}