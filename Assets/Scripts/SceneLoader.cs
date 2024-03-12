using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        var btn = this.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(OnClick); // Observer Pattern (Design Pattern)
    }

    void OnClick()
    {
        var input = FindObjectOfType<TMP_InputField>();
        int sceneNumber = int.Parse(input.text);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneNumber);
    }
}
