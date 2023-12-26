using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScriptableObject),true)]
public sealed class DocumentTips : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        DrawDefaultInspector();

        EditorGUILayout.Space();
        EditorGUILayout.Space();

        EditorGUILayout.LabelField(">「ID」 / 検索時に使用する名前(半角限定)。");
        EditorGUILayout.LabelField(">「Object Name」 / ゲーム内で使用される名前。");
        EditorGUILayout.LabelField(">「imageSprite」 / メニュー等で表示されるのオブジェクトの画像。");

        EditorGUILayout.LabelField(">「instObject」 / 建築の際に設置するオブジェクト。");
        EditorGUILayout.LabelField(">「previewObject」 / 設置前のプレビュー表示用のオブジェクト。");

        EditorGUILayout.LabelField(">「Explanation Text」 / 説明文。バックスラッシュスラッシュ + n を文章の間に入れる事で改行できる。。");
        EditorGUILayout.LabelField(">「Durability Point」 / 耐久力。体力の意味でもある。");
        EditorGUILayout.LabelField(">「Explosive Resist Rate」 / 爆発ダメージの倍率。[例]ダメージが半減するなら0.5f。");
        EditorGUILayout.LabelField(">「Attack Point」 / オブジェクトの攻撃力");
        EditorGUILayout.LabelField(">「」 /");
    }
}