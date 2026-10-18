using UnityEngine;
using UnityEngine.UI;

public class RandomizeImage : MonoBehaviour
{
    [SerializeField] private Image image;

    private Sprite[] images;

    void Start()
    {
        images = Resources.LoadAll<Sprite>("Random Images");
    }

    public void ChangeImage()
    {
        Sprite currentImage = image.sprite;
        Sprite newImage;

        do
        {
            newImage = images[Random.Range(0, images.Length)];
        }
        while (newImage == currentImage);

        image.sprite = newImage;
    }
}