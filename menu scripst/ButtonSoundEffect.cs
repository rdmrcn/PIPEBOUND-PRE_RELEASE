using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSoundEffect : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    // Mouse butonun üzerine geldiğinde (opsiyonel)
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (button != null && button.interactable)
        {
            if (AudioManager.Instance != null)
            {
                AudioManager.Instance.PlayButtonHover();
            }
        }
    }

    // Butona tıklandığında
    public void OnPointerClick(PointerEventData eventData)
    {
        if (button != null && button.interactable)
        {
            if (AudioManager.Instance != null)
            {
                AudioManager.Instance.PlayButtonClick();
            }
        }
    }
}