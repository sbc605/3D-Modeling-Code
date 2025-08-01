using UnityEngine;

public class StudyStatic : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"���� ������ ���� : {StaticClass.number}");
        
    }
}

public class StaticClass // ������
{
    public static StaticClass instance = new StaticClass(); // �̱���ó�� ��𼭵� ������ �� �ִ� instance��� ������ ���� ��
    public static int number = 10; // ����Ǹ鼭 �޸𸮿� �ִ� �͵� �ڸ�����(������ �ܰ迡�� �ڸ�����)

    public StaticClass()
    {
        Debug.Log($"������ ���� : {number}");
    }
}
