using UnityEngine;
using TMPro;

public class TMPDropdownHandler : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown languageDropdown;

    void Start()
    {
        languageDropdown.onValueChanged.AddListener(OnLanguageSelected);
    }

    void OnLanguageSelected(int index)
    {
        string selectedLanguage = languageDropdown.options[index].text;

        int activeProjectCount = 0;

        foreach (GameObject obj in ProjectManager.Instance.AllProjects)
        {
            MultiTag multiTag = obj.GetComponent<MultiTag>();
            if (selectedLanguage == "Tout" || (multiTag != null && multiTag.HasTag(selectedLanguage)))
            {
                obj.SetActive(true);
                activeProjectCount++;
            }
            else
            {
                obj.SetActive(false);
            }
        }

        ProjectManager.Instance.UpdateContentHeight(activeProjectCount);
    }
}
