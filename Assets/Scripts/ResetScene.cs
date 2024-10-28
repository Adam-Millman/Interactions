using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ResetScene : MonoBehaviour
{
    [SerializeField]
    private InputActionReference leftTrigger;
    [SerializeField]
    private InputActionReference rightTrigger;

    void Update()
    {
        if (leftTrigger.action.ReadValue<float>() > 0.9f && rightTrigger.action.ReadValue<float>() > 0.9f)
        {
            Reset();
        }
    }

    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
