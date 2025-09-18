using UnityEngine;
using UnityEngine.UI;

public class DualButtonTrigger : MonoBehaviour
{
    [Header("Botões")]
    public Button keyboardButton;
    public Button controllerButton;

    [Header("GameObjects de mensagens")]
    public GameObject keyboardMessage;   // Mensagem do teclado
    public GameObject controllerMessage; // Mensagem do controle

    void Start()
    {
        // Inicialmente, esconde todas as mensagens
        if (keyboardMessage != null) keyboardMessage.SetActive(false);
        if (controllerMessage != null) controllerMessage.SetActive(false);

        // Adiciona os listeners aos botões
        if (keyboardButton != null)
            keyboardButton.onClick.AddListener(() => ShowMessage("keyboard"));

        if (controllerButton != null)
            controllerButton.onClick.AddListener(() => ShowMessage("controller"));
    }

    void ShowMessage(string type)
    {
        switch (type)
        {
            case "keyboard":
                if (keyboardMessage != null) keyboardMessage.SetActive(true);
                if (controllerMessage != null) controllerMessage.SetActive(false);
                break;

            case "controller":
                if (controllerMessage != null) controllerMessage.SetActive(true);
                if (keyboardMessage != null) keyboardMessage.SetActive(false);
                break;
        }
    }
}