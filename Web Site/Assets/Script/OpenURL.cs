using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Cette fonction sera appelée lorsque le bouton sera cliqué
    public void OpenGoogle()
    {
        Application.OpenURL("https://www.google.com");
    }
    public void OpenCustomURL(string url)
    {
        Application.OpenURL(url);
    }
}
