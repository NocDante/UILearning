using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LoginView : MonoBehaviour
{
    // Start is called before the first frame update
    private InputField inputID;
    private InputField inputPass; 
    private Button buttonReset;
    private Button buttonLogin;
    private Text textStatus;
   void Awake() 
    {
        inputID = transform.Find( "InputFieldID")?.GetComponent<InputField>();
        inputPass = transform.Find( "InputFieldPass")?.GetComponent<InputField>();
        buttonReset = transform.Find( "ButtonReset")?.GetComponent<Button>();
        buttonLogin = transform.Find( "ButtonLogin")?.GetComponent<Button>();
        textStatus = transform.Find( "TextStatus")?.GetComponent<Text>();

        if(inputID==null || inputPass == null ||  buttonReset == null || buttonLogin == null || textStatus == null)
        {
           Debug.LogError("Auto binding failed");
           this.enabled = false;
        }
    }
    
    //設置操作介面
    //InputFieldID
    public string GetInputFieldID(){return inputID.text;}
    public void SetInputFieldID(string value){inputID.text = value;}
    //InputFieldPass
    public string GetInputFieldPass(){return inputPass.text;}
    public void SetInputFieldPass(string value){inputPass.text = value;}
    //textStates
    public void SetTextStatus(string value){textStatus.text = value;}
    //ButtonBindings
    public void BindButtonResetOnClick(UnityAction action){ buttonReset.onClick.AddListener(action); }
    public void BindButtonLoginOnClick(UnityAction action){ buttonLogin.onClick.AddListener(action); }
     //ButtonUnBindings
    public void UnBindButtonResetOnClick(UnityAction action){buttonReset.onClick.RemoveListener(action);}
    public void UnBindButtonResetOnClick(){buttonReset.onClick.RemoveAllListeners();}
    public void UnBindButtonLoginOnClick(UnityAction action){buttonLogin.onClick.RemoveListener(action);}
    public void UnBindButtonLoginOnClick(){buttonLogin.onClick.RemoveAllListeners();}
    
}
