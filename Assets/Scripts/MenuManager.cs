using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
   public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
