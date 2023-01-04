using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour
{
    [SerializeField] private GameObject _firstSelected;
    [SerializeField] private MenuPanel _menuPanel;
    [SerializeField] private Button _closeSettingsPanelButton;
    
    private EventSystem _eventSystem;

    private void Awake()
    {
        _eventSystem = EventSystem.current;
    }

    private void OnEnable()
    {
        _eventSystem.SetSelectedGameObject(_firstSelected);
        _closeSettingsPanelButton.onClick.AddListener(Close);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Close();
        }
    }

    private void OnDisable()
    {
        _closeSettingsPanelButton.onClick.RemoveListener(Close);
    }


    private void Close()
    {
        _menuPanel.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
