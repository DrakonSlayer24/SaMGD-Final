using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{

    public GameObject CreateRoomPanel;
    public GameObject JoinRoomPanel;
    public GameObject MenuPanel;

    public void OpenCPanel()
    {
        CreateRoomPanel.SetActive(true);
        JoinRoomPanel.SetActive(false);
        MenuPanel.SetActive(false);
    }

    public void OpenJPanel()
    {
        JoinRoomPanel.SetActive(true);
        CreateRoomPanel.SetActive(false);
        MenuPanel.SetActive(false);
    }

    public void LeaveButton()
    {
        JoinRoomPanel.SetActive(false);
        CreateRoomPanel.SetActive(false);
        MenuPanel.SetActive(true);
        //SceneManager.LoadScene("Loading");
    }
}
