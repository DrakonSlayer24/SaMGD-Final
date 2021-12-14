using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{

    public GameObject RoomPanel;
    public GameObject MenuPanel;

    public void OpenPanel()
    {
        RoomPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }
}
