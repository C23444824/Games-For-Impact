using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class FeedbackManager : MonoBehaviour
{
    [SerializeField] private string[] SucessSpeeches;
    [SerializeField] private string[] TeachFeedback;
    [SerializeField] private string[] NotFinished;
    public TextMeshProUGUI DisplayedText;

    public void GenerateFeedback(bool isFixed, bool needsFeedback)
    {
        if(isFixed && !needsFeedback)
        {
            DisplayedText.text = SucessSpeeches[Random.Range(0, SucessSpeeches.Length)];
        }

        if (isFixed && needsFeedback)
        {
            DisplayedText.text = TeachFeedback[Random.Range(0, TeachFeedback.Length)];
        }

        if (!isFixed)
        {
            DisplayedText.text = NotFinished[Random.Range(0, NotFinished.Length)];
        }
    }
}
