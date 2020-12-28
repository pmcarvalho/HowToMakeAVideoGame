using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel() 
    {

        completeLevelUI.SetActive(true);

    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {

            //Makes the Object stop being pushed
            FindObjectOfType<PlayerMovement>().enabled = false;
            //Makes the Score stop the count
            FindObjectOfType<Score>().enabled = false;

            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);

        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene("Level_1");//SceneManager.GetActiveScene().name
    }

}
