using UnityEngine;
using TMPro;

public class TMPDropdownHandler : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown languageDropdown;
    [SerializeField] private GameObject[] allProjects;
    [SerializeField] private RectTransform contentTransform;
    [SerializeField] private float projectHeight = 500f;
    readonly private string allOptionText = "Tout";

    void Start()
    {
        languageDropdown.onValueChanged.AddListener(OnLanguageSelected);
    }

    void OnLanguageSelected(int index)
    {
        string selectedLanguage = languageDropdown.options[index].text;

        int activeProjectCount = 0;

        foreach (GameObject obj in allProjects)
        {
            MultiTag multiTag = obj.GetComponent<MultiTag>();

            if (selectedLanguage == allOptionText)
            {
                obj.SetActive(true);
                activeProjectCount++;
            }
            else if (multiTag != null && multiTag.HasTag(selectedLanguage))
            {
                obj.SetActive(true);
                activeProjectCount++;
            }
            else
            {
                obj.SetActive(false);
            }
        }

        float newHeight = activeProjectCount * projectHeight;
        contentTransform.sizeDelta = new Vector2(contentTransform.sizeDelta.x, newHeight);
    }
}
