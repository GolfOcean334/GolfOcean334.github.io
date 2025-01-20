using UnityEngine;
using TMPro;

public class ProjectSearchHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField searchInputField;

    void Start()
    {
        searchInputField.onValueChanged.AddListener(OnSearchTextChanged);
    }

    void OnSearchTextChanged(string searchText)
    {
        int activeProjectCount = 0;

        foreach (GameObject project in ProjectManager.Instance.AllProjects)
        {
            ProjectTitle titleComponent = project.GetComponent<ProjectTitle>();
            if (titleComponent != null && titleComponent.Title.ToLower().Contains(searchText.ToLower()))
            {
                project.SetActive(true);
                activeProjectCount++;
            }
            else
            {
                project.SetActive(false);
            }
        }

        ProjectManager.Instance.UpdateContentHeight(activeProjectCount);
    }
}
