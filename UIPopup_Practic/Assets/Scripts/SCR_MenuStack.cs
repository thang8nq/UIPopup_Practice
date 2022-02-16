using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SCR_MenuStack : MonoBehaviour
{
    private Stack<GameObject> m_MenuStack = new Stack<GameObject>();

    public bool HasMenu()
    {
        return m_MenuStack.Count > 0;
    }

    public void OpenMenu(GameObject obj)
    {
        m_MenuStack.Push(obj);
        obj.SetActive(true);
    }

    public GameObject CloseMenu()
    {
        GameObject obj = m_MenuStack.Pop();
        obj.SetActive(false);
        return obj;
    }

    protected abstract void HandleRedirection();
    public abstract void OpenCoin();


}
