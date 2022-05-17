using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Story", menuName = "ScriptableObject/New Story")]
public class Story : ScriptableObject
{
    public Sprite LC;//������
    public Sprite RC;//������
    public string[] Sentence;//�ı�
    public bool[] Teller;//�����ߣ�falseΪ��trueΪ��
}
