using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginViewTest : MonoBehaviour
{
    private LoginView loginView;

    void Start()
    {
        loginView=GetComponent<LoginView>();
        loginView.BindButtonLoginOnClick(OnLogin);
        loginView.BindButtonResetOnClick(OnReset);
        loginView.SetTextStatus("Please login with your id and password");
    }

    // Update is called once per frame
    void OnLogin()
    {
        string id = loginView.GetInputFieldID();
        string pass = loginView.GetInputFieldPass();
        string status = "Logging...";

        if(id=="Su" && pass=="911214")
        {
            status = "Login success!";
        }
        else
        {
            status = "<color=red>You are fucking pussy!.</color>";
        }

        loginView.SetTextStatus(status);
    }
    void OnReset()
    {
        loginView.SetTextStatus("Please login with your id and password");
        loginView.SetInputFieldID("");
        loginView.SetInputFieldPass("");

    }

    void OnDestroy() 
    {
        loginView.UnBindButtonLoginOnClick();
        loginView.UnBindButtonResetOnClick();
    }
}
