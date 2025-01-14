using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void OpenGoogle()
    {
        Application.OpenURL("https://www.google.com");
    }
    public void OpenCustomURL(string url)
    {
        Application.OpenURL(url);
    }
}
