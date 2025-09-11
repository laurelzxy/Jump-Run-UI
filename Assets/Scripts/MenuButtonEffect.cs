using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class MenuButtonEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI buttonText;  
    public GameObject underline;
    public GameObject background; // fundo com degradê


    private Vector3 originalScale;

    void Start()
    {
        if (buttonText == null)
            buttonText = GetComponentInChildren<TextMeshProUGUI>();

        originalScale = buttonText.transform.localScale;

        if (underline != null)
            underline.SetActive(false);

        if (background != null)
            background.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.transform.localScale = originalScale * 1.1f; // aumenta o texto
        if (underline != null)
            underline.SetActive(true); // mostra a linha

        if (background != null)
            background.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.transform.localScale = originalScale; // volta ao tamanho normal
        if (underline != null)
            underline.SetActive(false); // esconde a linha

        if (background != null)
            background.SetActive(false);
    }
}
