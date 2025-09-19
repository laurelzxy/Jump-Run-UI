using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class UIButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Referências")]
    public Image icon;                 // Ícone do botão
    public TMP_Text text;              // Texto do botão (TextMeshPro)
    public GameObject underline;       // Linha embaixo (Image ou Panel)
    public GameObject background;      // Fundo com degradê (opcional)

    [Header("Cores")]
    public Color normalTextColor = Color.white;
    public Color hoverTextColor = Color.yellow;
    public Color normalIconColor = Color.white;
    public Color hoverIconColor = Color.yellow;

    [Header("Escala")]
    public float scaleMultiplier = 1.1f;
    public float lerpSpeed = 8f;

    private Vector3 originalScale;
    private bool isHovered = false;

    void Start()
    {
        originalScale = transform.localScale;

        if (underline != null)
            underline.SetActive(false);

        if (background != null)
            background.SetActive(false);

        if (icon != null)
        {
            icon.gameObject.SetActive(true); // garante que o ícone aparece
            icon.color = normalIconColor;    // cor inicial
        }

        if (text != null)
            text.color = normalTextColor;
    }


    void Update()
    {
        // Escala suave
        Vector3 targetScale = isHovered ? originalScale * scaleMultiplier : originalScale;
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * lerpSpeed);

        // Cor suave do ícone
        if (icon != null)
            icon.color = Color.Lerp(icon.color, isHovered ? hoverIconColor : normalIconColor, Time.deltaTime * lerpSpeed);

        // Cor suave do texto
        if (text != null)
            text.color = Color.Lerp(text.color, isHovered ? hoverTextColor : normalTextColor, Time.deltaTime * lerpSpeed);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;

        if (underline != null)
            underline.SetActive(true);

        if (background != null)
            background.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovered = false;

        if (underline != null)
            underline.SetActive(false);

        if (background != null)
            background.SetActive(false);
    }
}
