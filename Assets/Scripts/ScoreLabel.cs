using TMPro;
using UnityEngine;

public class ScoreLabel : MonoBehaviour
{
    public TMP_Text label;

    void Start()
    {
        var controller = FindObjectOfType<FlappyController>();
        controller.ScoreChange.AddListener(OnScoreChanged);
        OnScoreChanged(controller.score);
    }

    void OnScoreChanged(int newValue)
    {
        label.text = newValue.ToString();
    }
}
