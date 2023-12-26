using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickWindow : MonoBehaviour
{

    //格納用
    public ObjectDate_Scriptable SODate;//ScriptableObjectデータが格納される。

    string idDate;//検索時に入力する為の名前(半角限定)
    Sprite imageSpriteDate;//描画する際に使われる名前。
    string objectNameDate;//オブジェクトの画像。

    float durabilityPointDate;//オブジェクトの持つ耐久力。体力の意味でもある。
    float explosiveResistRateDate;//爆発ダメージの倍率。[例]ダメージが半減するなら0.5f。

    float attackPoint;//オブジェクトの持つ攻撃

    GameObject buildingToolOBJ;//建築画面「Building Tool」のオブジェクトを取得。

    public Image windowImage;//選択窓の画像表示。

    ObjectDetailWindow detailWindowsSC;//Find.tagを行った後、任意のタイミングで説明ウィンドウに情報を流す。
    BuildingTool buildingToolSC;
    void Start()
    {
        //Findで説明文関連を表示する場所を取得する。
        detailWindowsSC = GameObject.FindGameObjectWithTag("DetailWindow_OBJ").GetComponent<ObjectDetailWindow>();
        buildingToolOBJ = GameObject.FindGameObjectWithTag("BuildingTool_OBJ");
        buildingToolSC = buildingToolOBJ.GetComponent<BuildingTool>();
        detailWindowsSC.SODate_Detail = SODate;

            objectNameDate = SODate.objectName;//オブジェクトの名前を取得し、格納する。
        imageSpriteDate = SODate.imageSprite;//オブジェクトの画像データを取得し、格納する。

    }

    public void CursorEnter()//マウスカーソルが重なった際の処理。
    {
        detailWindowsSC.SODate_Detail = SODate;
        detailWindowsSC.PublishLoad();
        Debug.Log("重なった！");
    }

    public void ClickEnter()//クリックされた時の処理。
    {
        buildingToolSC.instObject = SODate.instObject;
        buildingToolSC.previewObject = SODate.previewObject;

        buildingToolSC.PickEnd();

        buildingToolSC.WindowActive(false);//選択ウィンドウを無効化。
        Debug.Log("押された！");
    }
}
