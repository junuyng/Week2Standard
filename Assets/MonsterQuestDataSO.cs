using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestData", menuName = "Scriptable Object/MonsterQuestData", order = 1)]
public class MonsterQuestDataSO : QusetDataSO
{
    public string monsterType;
    public int requiredMonsterKills;
    
    protected override string QuestInfo()
    {
        return $"{monsterType}를 {requiredMonsterKills}마리 소탕";
    }
    
}