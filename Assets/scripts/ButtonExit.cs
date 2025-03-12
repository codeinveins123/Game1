using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonExit : MonoBehaviour
{
    public Animator fade;
    public void click()
    {
        Debug.Log("CLICKED EXITGAME!");
        
        StartCoroutine(fadeOut());
    }

    public IEnumerator fadeOut()
    {
        Debug.Log("FADE STARTED");
        fade.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        Debug.Log("FADE ENDED");
        Application.Quit();
    }
}
