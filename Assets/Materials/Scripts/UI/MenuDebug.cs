using UnityEngine;
using TMPro;

public class MenuDebug : MonoBehaviour
{
    [SerializeField] private TMP_Text Text;

    public void Message(string text)
    {
        Text.text = text;
    }
}
