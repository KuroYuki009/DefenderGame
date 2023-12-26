using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pickWindowGenerator : MonoBehaviour
{
    ////アタッチ必須項目
    public GameObject pickWindowObject;//生成する際に使用するオブジェクト。
    public ObjectDate_Scriptable scriptableDate;//対象のscriptableデータ。

    public GameObject buildingMenuOBJ;//アタッチしたオブジェクトの位置に選択可能窓を生成する。
    public BuildingMenuWindow buildingMenuSC;//アタッチしたオブジェクトのスクリプトにこのスクリプトの情報を追加する。
    //格納用
    //Sprite sprite;//読み込んだデータに入ってある画像データを格納。

    void Start()
    {
        buildingMenuSC = buildingMenuOBJ.GetComponent<BuildingMenuWindow>();

        //Generat();//[テスト]生成する。
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)) Generat();//[テスト]生成する。
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
