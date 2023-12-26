using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable/Create ObjectDate")]

public class ObjectDate_Scriptable : ScriptableObject
{
    public string id;//検索時に入力する為の名前(半角限定)
    public string objectName;//描写する際に使われる名前。
    public Sprite imageSprite;//オブジェクトの画像。

    public GameObject instObject;//建築の際に設置するオブジェクト
    public GameObject previewObject;//設置前のプレビュー表示用のオブジェクト

    public string explanationText;//説明文。バックスラッシュ + n を文章の間に入れる事で改行できる。

    public float durabilityPoint;//オブジェクトの持つ耐久力。体力の意味でもある。
    public float explosiveResistRate;//爆発ダメージの倍率。[例]ダメージが半減するなら0.5f。

    public float attackPoint;//オブジェクトの持つ攻撃力。

}
