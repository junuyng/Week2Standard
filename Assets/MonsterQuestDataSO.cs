using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestData", menuName = "Scriptable Object/MonsterQuestData", order = 1)]
public class MonsterQuestDataSO : QusetDataSO
{
    public string monsterType;
    public int requiredMonsterKills;


    public override string GetQuestInfo()
    {
        string questInfo = base.GetQuestInfo();
        questInfo = questInfo + $"\n{monsterType}를 {requiredMonsterKills}마리 소탕";
        return questInfo;
    }
    
}