using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject _firstSelected;
    private EventSystem _eventSystem;

    private void Awake()
    {
        _eventSystem = EventSystem.current;
    }

    private void OnEnable()
    {
        _eventSystem.SetSelectedGameObject(_firstSelected);
    }
}
