using UnityEngine;

public class SwitchImage : MonoBehaviour
{
    [SerializeField] private GameObject image1;
    [SerializeField] private GameObject image2;
    private bool img1Active;
    void Start()
    {
        ActiveImage1();
    }

    void ActiveImage1()
    {
        image1.SetActive(true);
        img1Active = true;
        image2.SetActive(false);
    }
    void ActiveImage2()
    {
        image2.SetActive(true);
        img1Active = false;
        image1.SetActive(false);
    }

    public void ChangeImage()
    {
        if (img1Active == true)
        {
            ActiveImage2();
        }
        else
            ActiveImage1();
    }
}
