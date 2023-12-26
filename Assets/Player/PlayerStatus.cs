using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    string selectEquipSwitch;//�����i�̑I���Ɏg�p����Switch���p��string�ϐ��B

    //�ݒ�K�{�ϐ�
    public GameObject PrimaryWeaponOBJ;//�v���C�}��
    public GameObject SecondaryWeaponOBJ;//�Z�J���_��
    public GameObject MeleeWeaponOBJ;//�ߐڕ���
    public GameObject BuildingToolOBJ;

    //�i�[�p
    WeaponSafety PrimaryWeaponSafetySC = null;//�v���C�}���̃Z���t�e�B�[�X�N���v�g�i�[�p�B
    WeaponSafety SecondaryWeaponSafetySC = null;//�Z�J���_���̃Z���t�e�B�[�X�N���v�g�i�[�p�B
    WeaponSafety MeleeWeaponSafetySC = null;//�ߐڕ���̃Z���t�e�B�[�X�N���v�g�i�[�p�B
    [SerializeField]private WeaponSafety buildingToolSafetySC;//���z���u�̃Z���t�e�B�[�X�N���v�g�i�[�p�B
    void Start()
    {
        
        //�e�����ɕt���Ă������ǂݎ��B
        //PrimaryWeaponSafetySC = PrimaryWeaponOBJ.GetComponent<WeaponSafety>();
        //SecondaryWeaponSafetySC = SecondaryWeaponOBJ.GetComponent<WeaponSafety>();
        //MeleeWeaponSafetySC = MeleeWeaponOBJ.GetComponent<WeaponSafety>();
        //buildingToolSafetySC = BuildingToolOBJ.GetComponent<WeaponSafety>();
    }
    void Update()
    {
        if(PrimaryWeaponOBJ != null)//�v���C�}���������Ă���ꍇ�̂ݍ쓮�B
        {
            if(PrimaryWeaponSafetySC == null)
            {
                PrimaryWeaponSafetySC = PrimaryWeaponOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1) && selectEquipSwitch != "PrimaryWeapon")//alpha1�Ńv���C�}���ɐ؂�ւ���
            {
                CursorRestraint();
                PrimaryWeaponSafetySC.equipPickUpSW = true;
                selectEquipSwitch = "PrimaryWeapon";
            }
            else if (selectEquipSwitch != "PrimaryWeapon" && PrimaryWeaponSafetySC.equipPickUpSW == true)
                PrimaryWeaponSafetySC.equipPickUpSW = false;
        }


        if(SecondaryWeaponOBJ != null)//�Z�J���_������������Ă���ꍇ�̂ݍ쓮�B
        {
            if(SecondaryWeaponSafetySC == null)
            {
                SecondaryWeaponSafetySC = SecondaryWeaponOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) && selectEquipSwitch != "SecondaryWeapon")//alpha2�ŃZ�J���_���ɐ؂�ւ���B
            {
                CursorRestraint();
                SecondaryWeaponSafetySC.equipPickUpSW = true;
                selectEquipSwitch = "SecondaryWeapon";
            }
            else if (selectEquipSwitch != "SecondaryWeapon" && SecondaryWeaponSafetySC.equipPickUpSW == true)
                SecondaryWeaponSafetySC.equipPickUpSW = false;
        }


        if(MeleeWeaponOBJ != null)//�ߐڕ���������Ă���ꍇ�̂ݍ쓮�B
        {
            if(MeleeWeaponSafetySC == null)
            {
                MeleeWeaponSafetySC = MeleeWeaponOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.V) && selectEquipSwitch != "MeleeWeapon")//V�L�[�ŋߐڕ���ɐ؂�ւ���B
            {
                CursorRestraint();
                MeleeWeaponSafetySC.equipPickUpSW = true;
                selectEquipSwitch = "MeleeWeapon";
            }
            else if (selectEquipSwitch != "MeleeWeapon" && MeleeWeaponSafetySC.equipPickUpSW == true)
                MeleeWeaponSafetySC.equipPickUpSW = false;
        }


        if(BuildingToolOBJ != null)//�c�[���������Ă���ꍇ�̂ݍ쓮(��{�v���C���[���c�[������������Ƃ͂ł��Ȃ�)
        {
            if(buildingToolSafetySC == null)
            {
                buildingToolSafetySC = BuildingToolOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && selectEquipSwitch != "BuildingTool")//�r���h�c�[���ɐ؂�ւ���B
            {
                buildingToolSafetySC.equipPickUpSW = true;
                selectEquipSwitch = "BuildingTool";
            }
            else if (selectEquipSwitch != "BuildingTool" && buildingToolSafetySC.equipPickUpSW == true)
                buildingToolSafetySC.equipPickUpSW = false;
        }

        void CursorRestraint()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

    }
}
