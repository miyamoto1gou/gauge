using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    //Slider�R�[�|�l���g���Ǘ�����p
    Slider HPbar;
    //HP���`
    public int HP = 100;

    //���݂̎���
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //HP�o�[���擾
        HPbar = GameObject.Find("HPbar").GetComponent<Slider>();
        //HP�o�[�̍ő�l��HP�ɂ���
        HPbar.maxValue = HP;

        //HP�̏����l��100��
        HPbar.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
         // �N���b�N���ꂽ��
        if (Input.GetMouseButton(0))
           { 
            //�O�̃t���[������o�߂����b�������Z
              currentTime += Time.deltaTime;

            //���b�������s��
            if (currentTime >= 1.0f)
            {
                HPbar.value -= 10;
                currentTime = 0;
            }
        }
    }
}