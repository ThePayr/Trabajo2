using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameOverScreen : MonoBehaviour
{
    public Puntaje Puntaje;
    public void Setup(Puntaje puntaje)
    {
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
}
