using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;

public class spriteButton : MonoBehaviour, IPointerClickHandler,IPointerDownHandler, IPointerEnterHandler,IPointerUpHandler, IPointerExitHandler
{
    // Code adapted from https://stackoverflow.com/a/37906512 made by stackoverflow user Programmer

    // Variables
    [SerializeField] string levelToLoad;

    // ---------------------------------------------------------------------------

    void Start()
    {
        //Attach Physics2DRaycaster to the Camera for mouse input detection
        Camera.main.gameObject.AddComponent<Physics2DRaycaster>();

        addEventSystem();
    }

    //Add Event System to the Camera
    void addEventSystem()
    {
        GameObject eventSystem = null;
        GameObject tempObj = GameObject.Find("EventSystem");
        if (tempObj == null)
        {
            eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();
        }
        else
        {
            if ((tempObj.GetComponent<EventSystem>()) == null)
            {
                tempObj.AddComponent<EventSystem>();
            }

            if ((tempObj.GetComponent<StandaloneInputModule>()) == null)
            {
                tempObj.AddComponent<StandaloneInputModule>();
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(levelToLoad);
    }

    //---------------------------------------------------

    //Code below needed to keep needed IPointer inherited behaviour functional.
    public void OnPointerDown(PointerEventData eventData)
    {
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
    }
    public void OnPointerUp(PointerEventData eventData)
    {
    }
    public void OnPointerExit(PointerEventData eventData)
    {
    }
}