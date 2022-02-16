using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_MainMenuController : SCR_MenuStack
{
    [SerializeField] SCR_PopupCoin m_PopupCoin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void HandleRedirection()
    {
    }

    public override void OpenCoin()
    {
        ShowPopupCoin();
    }

    public void ShowPopupCoin()
    {
        OpenMenu(m_PopupCoin.gameObject);
        m_PopupCoin.Show();
    }
}
