using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemInitializer : MonoBehaviour
{
    void Start()
    {
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

        Debug.Log("EventSystem �������� � ����� �������������!");
    }
}
