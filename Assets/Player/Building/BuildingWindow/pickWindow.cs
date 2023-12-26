using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickWindow : MonoBehaviour
{

    //�i�[�p
    public ObjectDate_Scriptable SODate;//ScriptableObject�f�[�^���i�[�����B

    string idDate;//�������ɓ��͂���ׂ̖��O(���p����)
    Sprite imageSpriteDate;//�`�悷��ۂɎg���閼�O�B
    string objectNameDate;//�I�u�W�F�N�g�̉摜�B

    float durabilityPointDate;//�I�u�W�F�N�g�̎��ϋv�́B�̗͂̈Ӗ��ł�����B
    float explosiveResistRateDate;//�����_���[�W�̔{���B[��]�_���[�W����������Ȃ�0.5f�B

    float attackPoint;//�I�u�W�F�N�g�̎��U��

    GameObject buildingToolOBJ;//���z��ʁuBuilding Tool�v�̃I�u�W�F�N�g���擾�B

    public Image windowImage;//�I�𑋂̉摜�\���B

    ObjectDetailWindow detailWindowsSC;//Find.tag���s������A�C�ӂ̃^�C�~���O�Ő����E�B���h�E�ɏ��𗬂��B
    BuildingTool buildingToolSC;
    void Start()
    {
        //Find�Ő������֘A��\������ꏊ���擾����B
        detailWindowsSC = GameObject.FindGameObjectWithTag("DetailWindow_OBJ").GetComponent<ObjectDetailWindow>();
        buildingToolOBJ = GameObject.FindGameObjectWithTag("BuildingTool_OBJ");
        buildingToolSC = buildingToolOBJ.GetComponent<BuildingTool>();
        detailWindowsSC.SODate_Detail = SODate;

            objectNameDate = SODate.objectName;//�I�u�W�F�N�g�̖��O���擾���A�i�[����B
        imageSpriteDate = SODate.imageSprite;//�I�u�W�F�N�g�̉摜�f�[�^���擾���A�i�[����B

    }

    public void CursorEnter()//�}�E�X�J�[�\�����d�Ȃ����ۂ̏����B
    {
        detailWindowsSC.SODate_Detail = SODate;
        detailWindowsSC.PublishLoad();
        Debug.Log("�d�Ȃ����I");
    }

    public void ClickEnter()//�N���b�N���ꂽ���̏����B
    {
        buildingToolSC.instObject = SODate.instObject;
        buildingToolSC.previewObject = SODate.previewObject;

        buildingToolSC.PickEnd();

        buildingToolSC.WindowActive(false);//�I���E�B���h�E�𖳌����B
        Debug.Log("�����ꂽ�I");
    }
}
