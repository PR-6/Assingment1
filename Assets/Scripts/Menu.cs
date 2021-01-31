using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public InputField playerName;
    public static string username;

    public void StartGame()
    {
        Debug.Log("Player Name is: " + playerName.text);
        username = playerName.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static string userName()
    {
        return username;
    }
}
