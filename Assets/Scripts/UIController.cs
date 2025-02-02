using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject uiPanel;

    [SerializeField]
    private GameObject showInfoButton;

    public void ToggleUI()
    {
        if (showInfoButton.activeInHierarchy)
        {
            uiPanel.SetActive(true);
            showInfoButton.SetActive(false);
        }
        else
        {
            uiPanel.SetActive(false);
            showInfoButton.SetActive(true);
        }
    }
}
