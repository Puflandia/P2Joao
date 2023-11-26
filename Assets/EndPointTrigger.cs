using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPointTrigger : MonoBehaviour
{
    public Image endGameImage;
    public Button restartButton; 
    public AudioClip endGameSound; 
    private AudioSource audioSource;

    private void Start()
    {
       
        audioSource = GetComponent<AudioSource>();

        
        if (!audioSource && endGameSound)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

       
        if (audioSource && endGameSound)
        {
            audioSource.clip = endGameSound;
            audioSource.playOnAwake = false;
        }

        
        if (restartButton) restartButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Você chegou ao final!");

       
        if (endGameImage) endGameImage.gameObject.SetActive(true);

       
        if (restartButton) restartButton.gameObject.SetActive(true);

        if (audioSource && endGameSound) audioSource.Play();

        ;
    }

    public void RestartGame()
    {
        
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);

        
        Time.timeScale = 1;
    }
}


