using UnityEngine;
using UnityEngine.SceneManagement;


public class Gestormenuprincipal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            Ajustes();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            menu();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void menu()
    {
        SceneManager.LoadScene("menuprincipal"); //Asegurate de crear esta escena antes
    }

    public void Juego()
    {
        SceneManager.LoadScene("Juego"); //Asegurate de crear esta escena antes
    }

    public void Creditos()
    {
        SceneManager.LoadScene("creditos"); //Asegurate de crear esta escena antes
    }

    public void Ajustes()
    {
        Debug.Log("Abriendo menú de datos...");
        SceneManager.LoadScene("Config");
    }
    public void Exit()
    {
        Debug.Log("Saliendo del juego... :<");
        Application.Quit();
    }
}