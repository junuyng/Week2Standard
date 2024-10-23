# Week2_Standard
## 스파르타 내일 배움 캠프 꾸준 실습 

- 싱글톤 기능 구현 해보기
   - 정적(static) 필드를 활용하여 구현
   - 클래스에 정적 프로퍼티 Instance를 정의
      - 값을 읽을 때 instance가 null인지 확인 null이라면 QuestManager 타입을 가진 컴포넌트를 찾아서 넣기
      - 그럼에도 불구하고 null이라면 새로운 게임오브젝트를 생성
   - 한 개의 인스턴스가 유일하게 존재할 수 있도록 구현
  
- List / Dictionary를 활용한 ObjectPool 구현 해보기
   - 키 값을 통해 오브젝트 풀 리스트에 접근

-  Scriptable Object를 활용하여 데이터 구조화하기
   - QuestDataSO를 상속 받아 MonsterQuestDataSO와 EncounterQuestDataSO 정의
   - QuestDataSO quest로 접근을 해도 상속 클래스에 맞는 정보를 출력 

