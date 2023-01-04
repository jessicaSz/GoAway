using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SettingsPanelButton : MonoBehaviour
{
    [SerializeField] private SettingsPanel _settingsPanel;
    [SerializeField] private MenuPanel _menuPanel;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OpenSettingsPanel);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OpenSettingsPanel);
    }

    private void OpenSettingsPanel()
    {
        _settingsPanel.gameObject.SetActive(true);
        _menuPanel.gameObject.SetActive(false);
    }
}
