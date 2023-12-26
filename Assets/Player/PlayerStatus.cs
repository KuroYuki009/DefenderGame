using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    string selectEquipSwitch;//装備品の選択に使用するSwitch文用のstring変数。

    //設定必須変数
    public GameObject PrimaryWeaponOBJ;//プライマリ
    public GameObject SecondaryWeaponOBJ;//セカンダリ
    public GameObject MeleeWeaponOBJ;//近接武器
    public GameObject BuildingToolOBJ;

    //格納用
    WeaponSafety PrimaryWeaponSafetySC = null;//プライマリのセルフティースクリプト格納用。
    WeaponSafety SecondaryWeaponSafetySC = null;//セカンダリのセルフティースクリプト格納用。
    WeaponSafety MeleeWeaponSafetySC = null;//近接武器のセルフティースクリプト格納用。
    [SerializeField]private WeaponSafety buildingToolSafetySC;//建築装置のセルフティースクリプト格納用。
    void Start()
    {
        
        //各装備に付いている情報を読み取る。
        //PrimaryWeaponSafetySC = PrimaryWeaponOBJ.GetComponent<WeaponSafety>();
        //SecondaryWeaponSafetySC = SecondaryWeaponOBJ.GetComponent<WeaponSafety>();
        //MeleeWeaponSafetySC = MeleeWeaponOBJ.GetComponent<WeaponSafety>();
        //buildingToolSafetySC = BuildingToolOBJ.GetComponent<WeaponSafety>();
    }
    void Update()
    {
        if(PrimaryWeaponOBJ != null)//プライマリを持っている場合のみ作動。
        {
            if(PrimaryWeaponSafetySC == null)
            {
                PrimaryWeaponSafetySC = PrimaryWeaponOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1) && selectEquipSwitch != "PrimaryWeapon")//alpha1でプライマリに切り替える
            {
                CursorRestraint();
                PrimaryWeaponSafetySC.equipPickUpSW = true;
                selectEquipSwitch = "PrimaryWeapon";
            }
            else if (selectEquipSwitch != "PrimaryWeapon" && PrimaryWeaponSafetySC.equipPickUpSW == true)
                PrimaryWeaponSafetySC.equipPickUpSW = false;
        }


        if(SecondaryWeaponOBJ != null)//セカンダリ武器を持っている場合のみ作動。
        {
            if(SecondaryWeaponSafetySC == null)
            {
                SecondaryWeaponSafetySC = SecondaryWeaponOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) && selectEquipSwitch != "SecondaryWeapon")//alpha2でセカンダリに切り替える。
            {
                CursorRestraint();
                SecondaryWeaponSafetySC.equipPickUpSW = true;
                selectEquipSwitch = "SecondaryWeapon";
            }
            else if (selectEquipSwitch != "SecondaryWeapon" && SecondaryWeaponSafetySC.equipPickUpSW == true)
                SecondaryWeaponSafetySC.equipPickUpSW = false;
        }


        if(MeleeWeaponOBJ != null)//近接武器を持っている場合のみ作動。
        {
            if(MeleeWeaponSafetySC == null)
            {
                MeleeWeaponSafetySC = MeleeWeaponOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.V) && selectEquipSwitch != "MeleeWeapon")//Vキーで近接武器に切り替える。
            {
                CursorRestraint();
                MeleeWeaponSafetySC.equipPickUpSW = true;
                selectEquipSwitch = "MeleeWeapon";
            }
            else if (selectEquipSwitch != "MeleeWeapon" && MeleeWeaponSafetySC.equipPickUpSW == true)
                MeleeWeaponSafetySC.equipPickUpSW = false;
        }


        if(BuildingToolOBJ != null)//ツールを持っている場合のみ作動(基本プレイヤーがツールを手放すことはできない)
        {
            if(buildingToolSafetySC == null)
            {
                buildingToolSafetySC = BuildingToolOBJ.GetComponent<WeaponSafety>();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && selectEquipSwitch != "BuildingTool")//ビルドツールに切り替える。
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
