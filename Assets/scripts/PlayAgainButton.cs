using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public void PlayAgain()
    {
        Debug.Log("a");
        SceneManager.LoadScene(0);
    }
}
