using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectDetailWindow : MonoBehaviour
{
    //�ۊǗp
    public ObjectDate_Scriptable SODate_Detail;//pickWindow���瑗���Ă������ۊǂ���B

    //��`�K�{
    public Text objectNameWindow;//�Ώۂ̃I�u�W�F�N�g����\�L����ꏊ�B
    public Image imageSpriteWindow;//�Ώۂ̃I�u�W�F�N�g�̉摜��\�L����ꏊ�B
    public Text explanTextWindow;//�Ώۂ̃I�u�W�F�N�g�̐�������\�L����ꏊ�B

    public void PublishLoad()//pickWindow�����񂪑����Ă���ۂ�sendMessege�œǂݍ��݂��s���B
    {
        objectNameWindow.text = SODate_Detail.objectName;//���O��ǂݍ��܂���B
        imageSpriteWindow.sprite = SODate_Detail.imageSprite;//�摜��ǂݍ��܂���B
        explanTextWindow.text = SODate_Detail.explanationText;//��������ǂݍ��܂���B
    }
}
