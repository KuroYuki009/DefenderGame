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

        EditorGUILayout.LabelField(">�uID�v / �������Ɏg�p���閼�O(���p����)�B");
        EditorGUILayout.LabelField(">�uObject Name�v / �Q�[�����Ŏg�p����閼�O�B");
        EditorGUILayout.LabelField(">�uimageSprite�v / ���j���[���ŕ\�������̃I�u�W�F�N�g�̉摜�B");

        EditorGUILayout.LabelField(">�uinstObject�v / ���z�̍ۂɐݒu����I�u�W�F�N�g�B");
        EditorGUILayout.LabelField(">�upreviewObject�v / �ݒu�O�̃v���r���[�\���p�̃I�u�W�F�N�g�B");

        EditorGUILayout.LabelField(">�uExplanation Text�v / �������B�o�b�N�X���b�V���X���b�V�� + n �𕶏͂̊Ԃɓ���鎖�ŉ��s�ł���B�B");
        EditorGUILayout.LabelField(">�uDurability Point�v / �ϋv�́B�̗͂̈Ӗ��ł�����B");
        EditorGUILayout.LabelField(">�uExplosive Resist Rate�v / �����_���[�W�̔{���B[��]�_���[�W����������Ȃ�0.5f�B");
        EditorGUILayout.LabelField(">�uAttack Point�v / �I�u�W�F�N�g�̍U����");
        EditorGUILayout.LabelField(">�u�v /");
    }
}