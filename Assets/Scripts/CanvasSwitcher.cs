using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    [Header("Canvases")]
    public GameObject menuCanvas;
    public GameObject gameCanvas;
    public GameObject characterCanvas;
    public GameObject settingsCanvas;
    public GameObject creditsCanvas;
    public GameObject multiplayerCanvas;
    public GameObject rooomCanvas;
    public GameObject createCanvas;


    [Header("Audio")]
    public AudioSource buttonSound; // arraste o AudioSource aqui no inspector

    // Método para tocar o som
    private void PlayButtonSound()
    {
        if (buttonSound != null)
            buttonSound.Play();
    }

    public void PlayGame()
    {
        PlayButtonSound(); // toca o som
        if (menuCanvas != null) menuCanvas.SetActive(false);
        if (multiplayerCanvas != null) multiplayerCanvas.SetActive(true);
    }

    public void OpenCharacters()
    {
        PlayButtonSound();
        if(menuCanvas != null) menuCanvas.SetActive(false);
        if(characterCanvas != null) characterCanvas.SetActive(true);
    }


    public void OpenSettings()
    {
        PlayButtonSound();
        if (menuCanvas != null) menuCanvas.SetActive(false);
        if (settingsCanvas != null) settingsCanvas.SetActive(true);
    }

    public void OpenCredits()
    {
        PlayButtonSound();
        if (menuCanvas != null) menuCanvas.SetActive(false);
        if (creditsCanvas != null) creditsCanvas.SetActive(true);
    }

    public void OpenMultiplayer()
    {
        PlayButtonSound();
        if (multiplayerCanvas != null) multiplayerCanvas.SetActive(false);
        if (rooomCanvas != null) rooomCanvas.SetActive(true);
    }

    public void ExitGame()
    {
        PlayButtonSound();
        Application.Quit();
        Debug.Log("Jogo fechado.");
    }

    public void BackMulti()
    {
               PlayButtonSound();
        if (rooomCanvas != null) rooomCanvas.SetActive(false);
        if (multiplayerCanvas != null) multiplayerCanvas.SetActive(true);
    }
    public void BackToMenu()
    {
        PlayButtonSound();
        if (gameCanvas != null) gameCanvas.SetActive(false);
        if (characterCanvas != null) characterCanvas.SetActive(false);
        if (settingsCanvas != null) settingsCanvas.SetActive(false);
        if (creditsCanvas != null) creditsCanvas.SetActive(false);
        if (multiplayerCanvas != null) multiplayerCanvas.SetActive(false);
        if (rooomCanvas != null) rooomCanvas.SetActive(false);


        if (menuCanvas != null) menuCanvas.SetActive(true);
    }
}
