using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool bCheck_Parameter = true;
    public static int bHardware = 0;

    [SerializeField] private InputField Name_Input;
    [SerializeField] private InputField Password_Input;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MyButtonScript()
    {
        Debug.Log("소환사의 협곡에 오신걸 환영합니다.");
    }
    public void MyCheckButtonScript()
    {
        if (bCheck_Parameter == true)
        {
            bCheck_Parameter = false;
        }else if (bCheck_Parameter == false)
        {
            bCheck_Parameter = true;
        }
        Debug.Log("확인되었습니다." + bCheck_Parameter);
    }
    public void MyInputField_Name()
    {
        if (Name_Input.text == "가족수호자파이몬")
        {
            Debug.Log("이미 존재하는 닉네임입니다.");
        }
    }
    public void MyInputField_Password()
    { 
        if (Password_Input.text == "demonking666")
        {
            Debug.Log("암호가 일치합니다.");
        }
    }
}
