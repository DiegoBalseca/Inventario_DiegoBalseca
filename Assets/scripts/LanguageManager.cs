using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Text[] texts; 

    public void ChangeLanguage(ScriptableLanguage language)
    {
        texts[0].text = language.text1;
        texts[1].text = language.text2;
        texts[2].text = language.text3;
        texts[3].text = language.text4;
    }
}