using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ComicSlideShow : MonoBehaviour
{
    public AudioSettings audioSettings;
    public Scenes gotoScene;

    public Image image;
    public TextMeshProUGUI text;
    public float timeBetweenSlides = 1.0f;
    public List<Sprite> slides;

    float timer = 0.0f;
    int i = 0;

    private void Start()
    {
        image.sprite = slides[0];
        timer = timeBetweenSlides;
        text.gameObject.SetActive(false);
    }

    public void Update()
    {
        AlignText();

        image.sprite = slides[i];

        timer -= Time.deltaTime;

        if (timer <= 0 && i < slides.Count - 1)
        {
            i++;
            timer = timeBetweenSlides;
        }
    }

    public void SkipSlide()
    {
        if (i < slides.Count - 1)
        {
            i++;
            timer = timeBetweenSlides;
            return;
        }
        if (i == slides.Count - 1)
        {
            audioSettings.SetValues();

            if (gotoScene.ToString() != Scenes.NULL.ToString())
                SceneManager.LoadScene(gotoScene.ToString(), LoadSceneMode.Single);
        }
    }

    void AlignText()
    {
        if (i == slides.Count - 1)
        {
            text.gameObject.SetActive(true);
            text.alignment = TextAlignmentOptions.Bottom;
            text.text = "Click To Continue";
        }
    }
}