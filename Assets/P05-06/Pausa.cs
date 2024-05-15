using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject B_Menu;
    private bool pause = false;
    public void pausa()
    {
        pause = true;
        Time.timeScale = 0.0f;
        B_Menu.SetActive(true);
    }

    public void reanudar ()
    {
        pause = false;
        Time.timeScale = 1.0f;
        B_Menu.SetActive(false);
    }

    public void reiniciar ()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void cerrar ()
    {
        Debug.Log("Cerrar");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel") || OVRInput.Get(OVRInput.Button.Start))
        {
            if (!pause)
            {
                pausa();
            }
            else
            {
                reanudar();
            }
            
        }
    }
        
}
