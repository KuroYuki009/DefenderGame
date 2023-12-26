using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSafety : MonoBehaviour
{
    public MonoBehaviour weaponScript;//武器制御のスクリプトを貼り付ける必要がある。

    public GameObject modelObject;//武器のモデルを入れる必要がある。

    //変数。
    public bool equipPickUpSW;//現在装備中かどうか。偽=非装備。真=装備中。

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
