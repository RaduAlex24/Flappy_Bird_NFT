using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManageGame : MonoBehaviour
{

    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Win()
    {
        SceneManager.LoadScene(14);
    }

    public void WinFree()
    {
        SceneManager.LoadScene(17);
    }

    public void Replay2()
    {
        SceneManager.LoadScene(4);
    }

    public void Play5()
    {
        SceneManager.LoadScene(9);
    }

    public void Replay3()
    {
        SceneManager.LoadScene(5);
    }

    public void Replay4()
    {
        SceneManager.LoadScene(10);
    }

    public void Replay3Golden()
    {
        SceneManager.LoadScene(11);
    }

    public void Replay2Golden()
    {
        SceneManager.LoadScene(12);
    }

    public void ReplayGolden()
    {
        SceneManager.LoadScene(13);
    }

    public void MainSorry()
    {
        SceneManager.LoadScene(6);
    }

    public void Sacaracuca()
    {
        SceneManager.LoadScene(11);
    }


}
