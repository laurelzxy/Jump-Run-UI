using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TabManager : MonoBehaviour
{
    [Header("Abas")]
    public Button gameplayButton;
    public Button audioButton;
    public Button controlsButton;

    [Header("Pain�is")]
    public GameObject gameplayPanel;
    public GameObject audioPanel;
    public GameObject controlsPanel;

    [Header("Cores")]
    public Color selectedColor = Color.red;
    public Color normalColor = Color.white;

    void Start()
    {
        // Inicializa todos os bot�es
        gameplayButton.onClick.AddListener(() => SelectTab(gameplayButton, gameplayPanel));
        audioButton.onClick.AddListener(() => SelectTab(audioButton, audioPanel));
        controlsButton.onClick.AddListener(() => SelectTab(controlsButton, controlsPanel));

        // Seleciona uma aba padr�o no in�cio (opcional)
        SelectTab(gameplayButton, gameplayPanel);
    }

    void SelectTab(Button selectedButton, GameObject selectedPanel)
    {
        // Reseta cores dos bot�es
        ResetButtonColors();

        // Muda a cor do texto do bot�o selecionado
        TextMeshProUGUI buttonText = selectedButton.GetComponentInChildren<TextMeshProUGUI>();
        if (buttonText != null)
            buttonText.color = selectedColor;

        // Ativa o painel correspondente e desativa os outros
        gameplayPanel.SetActive(selectedPanel == gameplayPanel);
        audioPanel.SetActive(selectedPanel == audioPanel);
        controlsPanel.SetActive(selectedPanel == controlsPanel);
    }

    void ResetButtonColors()
    {
        SetButtonTextColor(gameplayButton, normalColor);
        SetButtonTextColor(audioButton, normalColor);
        SetButtonTextColor(controlsButton, normalColor);
    }

    void SetButtonTextColor(Button btn, Color color)
    {
        TextMeshProUGUI text = btn.GetComponentInChildren<TextMeshProUGUI>();
        if (text != null)
            text.color = color;
    }
}
