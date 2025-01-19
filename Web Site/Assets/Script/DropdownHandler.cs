using UnityEngine;
using TMPro;

public class TMPDropdownHandler : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown languageDropdown;
    [SerializeField] private GameObject[] allGameObjects;

    void Start()
    {
        languageDropdown.onValueChanged.AddListener(OnLanguageSelected);
    }

    void OnLanguageSelected(int index)
    {
        string selectedLanguage = languageDropdown.options[index].text;

        foreach (GameObject obj in allGameObjects)
        {
            if (obj.CompareTag(selectedLanguage))
            {
                obj.SetActive(true);
            }
            else
            {
                obj.SetActive(false);
            }
        }
    }
}
