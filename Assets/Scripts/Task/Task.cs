using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Task", menuName = "ScriptableObject/New Task")]
public class Task : ScriptableObject
{
    public int taskType;//0ӵ��һ����������;1���һ�����������Ľ���;2����ָ���ص�;
    public GameObject taskObject;//���轨��
    public Item needItem;//������Ʒ
    public int needNum;//��Ҫ������
    public int nowNum;//��������
    public string introduce;//����
    public Task nextTask;//��һ������
    public float pointNum;//Ŀ�����
    public Story TaskStory;//��������
}
