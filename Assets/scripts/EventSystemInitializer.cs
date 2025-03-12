using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemInitializer : MonoBehaviour
{
    void Start()
    {
        // Проверяем, есть ли EventSystem в сцене
        if (FindObjectOfType<EventSystem>() == null)
        {
            CreateEventSystem();
        }
    }

    void CreateEventSystem()
    {
        GameObject eventSystemGO = new GameObject("EventSystem");
        eventSystemGO.AddComponent<EventSystem>();
        eventSystemGO.AddComponent<StandaloneInputModule>();

        Debug.Log("EventSystem добавлен в сцену автоматически!");
    }
}
