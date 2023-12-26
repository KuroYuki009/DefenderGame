using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable/Create ObjectDate")]

public class ObjectDate_Scriptable : ScriptableObject
{
    public string id;//�������ɓ��͂���ׂ̖��O(���p����)
    public string objectName;//�`�ʂ���ۂɎg���閼�O�B
    public Sprite imageSprite;//�I�u�W�F�N�g�̉摜�B

    public GameObject instObject;//���z�̍ۂɐݒu����I�u�W�F�N�g
    public GameObject previewObject;//�ݒu�O�̃v���r���[�\���p�̃I�u�W�F�N�g

    public string explanationText;//�������B�o�b�N�X���b�V�� + n �𕶏͂̊Ԃɓ���鎖�ŉ��s�ł���B

    public float durabilityPoint;//�I�u�W�F�N�g�̎��ϋv�́B�̗͂̈Ӗ��ł�����B
    public float explosiveResistRate;//�����_���[�W�̔{���B[��]�_���[�W����������Ȃ�0.5f�B

    public float attackPoint;//�I�u�W�F�N�g�̎��U���́B

}
