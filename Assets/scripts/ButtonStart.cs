using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonStart : MonoBehaviour
{
    public Animator fade;
    public void click()
    {
        Debug.Log("CLICKED STARTGAME!");
        
        StartCoroutine(fadeOut());
    }

    public IEnumerator fadeOut()
    {
        Debug.Log("FADE STARTED");
        fade.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        Debug.Log("FADE ENDED");
        SceneManager.LoadScene("GameScene");
    }
}