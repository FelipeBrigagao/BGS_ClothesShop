using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamHelper : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _mainCam;
    [SerializeField] private CinemachineVirtualCamera _inventoryCam;

    private void OnEnable()
    {
        if (UiManager.Instance)
        {
            UiManager.Instance.OnPlayerInventoryOpen += ChangeToInventoryCam;
            UiManager.Instance.OnPlayerInventoryClose += ChangeToMainCam;
        }
    }
    private void OnDisable()
    {
        if (UiManager.Instance)
        {
            UiManager.Instance.OnPlayerInventoryOpen -= ChangeToInventoryCam;
            UiManager.Instance.OnPlayerInventoryClose -= ChangeToMainCam;
        }
    }

    public void ChangeToMainCam()
    {
        _mainCam.gameObject.SetActive(true);
        _inventoryCam.gameObject.SetActive(false);
    }

    public void ChangeToInventoryCam()
    {
        _inventoryCam.gameObject.SetActive(true);
        _mainCam.gameObject.SetActive(false);
    }
}
