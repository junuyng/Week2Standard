using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuestData", menuName = "Scriptable Object/EncounterQuestData", order = 2)]
public class EncounterQuestDataSO : QusetDataSO
{
   public string challengeTask;
   
   public override string GetQuestInfo()
   {
      string questInfo = base.GetQuestInfo();
      questInfo = questInfo + $"\n{challengeTask}";
      
      return questInfo;
   }
   
   //TODO 문자열 계산 경우 메모리 손실 큼. 
   // override 를 통해 함수를 가져왔을 때 base를 쓰지 않더라도 부모의 성질을 가져와 쓴 개념 
   // 성질이 같으면 상관 X 
   // 부모로 부터 퀘스트의 정보만을 표현하는  GetQuestInfo를 상속 받은 퀘스트에서  questInfo가 아닌 부분을 return 하거나 목적과 달라지면 안 된다 .
   // 개발 편의성과 객체 지향 사이에서 타협 
}
