using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pickWindowGenerator : MonoBehaviour
{
    ////�A�^�b�`�K�{����
    public GameObject pickWindowObject;//��������ۂɎg�p����I�u�W�F�N�g�B
    public ObjectDate_Scriptable scriptableDate;//�Ώۂ�scriptable�f�[�^�B

    public GameObject buildingMenuOBJ;//�A�^�b�`�����I�u�W�F�N�g�̈ʒu�ɑI���\���𐶐�����B
    public BuildingMenuWindow buildingMenuSC;//�A�^�b�`�����I�u�W�F�N�g�̃X�N���v�g�ɂ��̃X�N���v�g�̏���ǉ�����B
    //�i�[�p
    //Sprite sprite;//�ǂݍ��񂾃f�[�^�ɓ����Ă���摜�f�[�^���i�[�B

    void Start()
    {
        buildingMenuSC = buildingMenuOBJ.GetComponent<BuildingMenuWindow>();

        //Generat();//[�e�X�g]��������B
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)) Generat();//[�e�X�g]��������B
    }
    void Generat()
    {
        GameObject instObject = Instantiate(pickWindowObject,buildingMenuOBJ.transform);
        buildingMenuSC.pickWindow_Object.Add(instObject);

        pickWindow pickWindowSC = instObject.GetComponent<pickWindow>();

        if (pickWindowSC == null)
        {
            return;
        }
        pickWindowSC.SODate = scriptableDate;
    }
}
