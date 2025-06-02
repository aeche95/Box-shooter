using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{

    Button StartButton;
    private void OnEnable()
    {
        UIDocument document = GetComponent<UIDocument>();
        VisualElement Root = document.rootVisualElement;

        StartButton = Root.Q<Button>("StartButton");

        StartButton.clicked += OnStartButtonClicked;
    }

    private void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Level1");
    }
}
