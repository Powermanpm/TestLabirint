using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{

    public void RestartButton(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
