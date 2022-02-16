using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SCR_PopupCoin : MonoBehaviour
{

    [SerializeField] SCR_MenuStack m_MenuStack;
    [SerializeField] TextMeshProUGUI numCoinTXT; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        numCoinTXT.text = "999";
    }

    public void Hide()
    {
        m_MenuStack.CloseMenu();
    }
}
