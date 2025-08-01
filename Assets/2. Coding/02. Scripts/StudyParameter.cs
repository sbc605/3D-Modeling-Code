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

        ParamsParameter(10, 20, 30); // ���������� �� ���� �� ����

        // NormalParameter(number);

        // ReferenceParameter(ref number);

        //DefaultParameter();
        //DefaultParameter(5);
    }

    // �Ϲ����� �Ű����� ���
    private void NormalParameter(int num) 
    {
        // number = num;
        num = 10;
        number = num;
    }

    // ���� ����� �Ű�����(����)
    private void ReferenceParameter(ref int num)
    {
        num = 20;
    }

    // ��ȯ�� ����(���)
    // �ʱ�ȭ���� �ʾƵ� ��� ����
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
        // ���� ������ �־����
        hp = 90;
        mp = 30;
    }

    // �迭�� �޾Ƽ� ����ϴ� ���
    // Collection�� �Ű������� ���� ���
    private void ArrayParameter(int[] numbers)
    {
        foreach (var n in numbers)
        {
            Debug.Log(n);
        }
    }

    // params�� Ȱ���� �Ű����� -> ���ڸ� ���� �־ ��� ����
    private void ParamsParameter(params int[] numbers)
    {
        foreach (var n in numbers)
        {
            Debug.Log(n);
        }
    }
    // Default �Ű�����(������ �Ű�����)
    private void DefaultParameter(int num = 3)
    {
        number = num;
    }

    #region Overloading
    // �����ε� : �Ű������� �ٸ����ؼ� �ٸ� ����� �����ϴ� ���
    private void OverloadingMethod() { }
    private void OverloadingMethod(int num) { }
    private void OverloadingMethod(float num) { }
    private void OverloadingMethod(bool isnum) { }
    private void OverloadingMethod(int num1, int num2) { }
    #endregion





}
