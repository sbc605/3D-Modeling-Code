using UnityEngine;

public class StudyStatic : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"정적 변수에 접근 : {StaticClass.number}");
        
    }
}

public class StaticClass // 생성자
{
    public static StaticClass instance = new StaticClass(); // 싱글톤처럼 어디서든 접근할 수 있는 instance라는 변수를 만든 것
    public static int number = 10; // 실행되면서 메모리에 있는 것들 자리잡음(컴파일 단계에서 자리잡음)

    public StaticClass()
    {
        Debug.Log($"생성자 실행 : {number}");
    }
}
