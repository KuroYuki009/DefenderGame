using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSafety : MonoBehaviour
{
    public MonoBehaviour weaponScript;//���퐧��̃X�N���v�g��\��t����K�v������B

    public GameObject modelObject;//����̃��f��������K�v������B

    //�ϐ��B
    public bool equipPickUpSW;//���ݑ��������ǂ����B�U=�񑕔��B�^=�������B

    void Start()
    {
        modelObject.SetActive(false);
    }


    void Update()
    {
        if(equipPickUpSW == true)
        {
            weaponScript.enabled = true;
            modelObject.SetActive(true);
        }
        else if(equipPickUpSW == false)
        {
            weaponScript.enabled = false;
            modelObject.SetActive(false);
        }
    }
}
