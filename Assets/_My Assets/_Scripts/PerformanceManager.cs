using UnityEngine;

public class PerformanceManager : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
}
