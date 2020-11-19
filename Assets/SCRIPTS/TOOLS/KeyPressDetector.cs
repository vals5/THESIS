using UnityEngine;
using UnityEngine.Events;
public class KeyPressDetector : MonoBehaviour
{
    public KeyCode key = KeyCode.Return;
    public UnityEvent unityAction;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            unityAction?.Invoke();
        }    
    }
}
