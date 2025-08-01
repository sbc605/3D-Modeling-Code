using UnityEngine;


public partial class StudyPartial : MonoBehaviour
{
    public void MethodB()
    {
        Debug.Log("Method B");
    }
}


public class StudyParameter : MonoBehaviour
{
    public int number = 1;
    public int number2;

    public int hp = 100;
    public int mp = 50;

    public GameObject player;
    public GameObject enemy;
    public GameObject item;

    private void GameObjectActivate2(bool isActive, params GameObject[] objs)
    {
        foreach (var o in objs)
        {
            o.SetActive(isActive);
        }
    }

    private void Start()
    {
        StudyPartial studyPartical = new StudyPartial();
        studyPartical.MethodB();

        GameObjectActivate2(false, player, enemy, item);

        // OutParameter(out number, out number2);
        // UseSkill(out hp, out mp);

        int[] intArray = new int[3] {10, 20, 30 };
        ArrayParameter(intArray);

        ParamsParameter(10, 20, 30); // 직접적으로 값 넣을 수 있음

        // NormalParameter(number);

        // ReferenceParameter(ref number);

        //DefaultParameter();
        //DefaultParameter(5);
    }

    // 일반적인 매개변수 방법
    private void NormalParameter(int num) 
    {
        // number = num;
        num = 10;
        number = num;
    }

    // 참조 방식의 매개변수(수정)
    private void ReferenceParameter(ref int num)
    {
        num = 20;
    }

    // 반환의 개념(출력)
    // 초기화하지 않아도 사용 가능
    private void OutParameter(out int num)
    {
        num = 30;
    }

    private void OutParameter(out int num, out int num2)
    {
        num = 30;
        num2 = 50;
    }

    private void UseSkill(out int hp, out int mp)
    {
        // 원래 연산기능 넣어야함
        hp = 90;
        mp = 30;
    }

    // 배열을 받아서 사용하는 경우
    // Collection을 매개변수로 넣은 경우
    private void ArrayParameter(int[] numbers)
    {
        foreach (var n in numbers)
        {
            Debug.Log(n);
        }
    }

    // params를 활용한 매개변수 -> 인자를 직접 넣어서 사용 가능
    private void ParamsParameter(params int[] numbers)
    {
        foreach (var n in numbers)
        {
            Debug.Log(n);
        }
    }
    // Default 매개변수(선택적 매개변수)
    private void DefaultParameter(int num = 3)
    {
        number = num;
    }

    #region Overloading
    // 오버로딩 : 매개변수를 다르게해서 다른 기능을 구현하는 방법
    private void OverloadingMethod() { }
    private void OverloadingMethod(int num) { }
    private void OverloadingMethod(float num) { }
    private void OverloadingMethod(bool isnum) { }
    private void OverloadingMethod(int num1, int num2) { }
    #endregion





}
