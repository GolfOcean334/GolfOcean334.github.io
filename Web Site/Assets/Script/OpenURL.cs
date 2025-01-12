using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Cette fonction sera appel�e lorsque le bouton sera cliqu�
    public void OpenGoogle()
    {
        Application.OpenURL("https://www.google.com");
    }
    public void OpenCustomURL(string url)
    {
        Application.OpenURL(url);
    }
}
