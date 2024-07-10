using UnityEngine.SceneManagement;
using UnityEngine;

public class Minimanager : MonoBehaviour
{
    public void ChangeScene() 
    {
        SceneManager.LoadScene("GameScene");
    }
}
