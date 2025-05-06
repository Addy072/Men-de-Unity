using UnityEngine;
using UnityEngine.SceneManagement;

public class Gestorescenas : MonoBehaviour
{
    private static string escenaAnterior;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escenaAnterior = SceneManager.GetActiveScene().name;

    }

    // Update is called once per frame
    public void VolverEscenaAnterior()
    {
        if(!string.IsNullOrEmpty(escenaAnterior))
        {
            SceneManager.LoadScene(escenaAnterior);
        }
    }
}
