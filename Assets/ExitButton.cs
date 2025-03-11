using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    public Animator fade;
    public void click()
    {
        Debug.Log("CLICKED STARTGAME!");
        fade.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
    }
}
