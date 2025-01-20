using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    public static ProjectManager Instance; // Singleton pour un accès global

    [SerializeField] private GameObject[] allProjects;
    [SerializeField] private RectTransform contentTransform;
    [SerializeField] private float projectHeight = 500f;

    public GameObject[] AllProjects => allProjects;
    public RectTransform ContentTransform => contentTransform;
    public float ProjectHeight => projectHeight;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateContentHeight(int activeProjectCount)
    {
        float newHeight = activeProjectCount * projectHeight;
        contentTransform.sizeDelta = new Vector2(contentTransform.sizeDelta.x, newHeight);
    }
}
