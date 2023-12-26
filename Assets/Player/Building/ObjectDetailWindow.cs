using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectDetailWindow : MonoBehaviour
{
    //保管用
    public ObjectDate_Scriptable SODate_Detail;//pickWindowから送られてくる情報を保管する。

    //定義必須
    public Text objectNameWindow;//対象のオブジェクト名を表記する場所。
    public Image imageSpriteWindow;//対象のオブジェクトの画像を表記する場所。
    public Text explanTextWindow;//対象のオブジェクトの説明文を表記する場所。

    public void PublishLoad()//pickWindowから情報が送られてくる際にsendMessegeで読み込みを行う。
    {
        objectNameWindow.text = SODate_Detail.objectName;//名前を読み込ませる。
        imageSpriteWindow.sprite = SODate_Detail.imageSprite;//画像を読み込ませる。
        explanTextWindow.text = SODate_Detail.explanationText;//説明文を読み込ませる。
    }
}
