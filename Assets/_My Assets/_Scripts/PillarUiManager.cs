using UnityEditor;
using UnityEngine;

public class PillarUiManager : MonoBehaviour
{
    [SerializeField] string playerTag;
    [SerializeField] Animator pillarUiAnimation;

    [Header("Animation tag")]
    [SerializeField] string growTag;
    [SerializeField] string shrinkTag;

    [Header("Pannels")]
    [SerializeField] GameObject questionPannel;
    [SerializeField] GameObject informationPannel;

    private void Start()
    {
        questionPannel.SetActive(false);
        informationPannel.SetActive(false);
    }

    private void OnTriggerEnter(Collider info)
    {
        if (info.CompareTag(playerTag))
            pillarUiAnimation.SetTrigger(growTag);
    }

    private void OnTriggerExit(Collider info)
    {
        if (info.CompareTag(playerTag))
            pillarUiAnimation.SetTrigger(shrinkTag);
    }

    public void B_Open(GameObject desireObject)
    {
        CloseAllPanel();
        desireObject.SetActive(true);
    }

    public void B_Close (GameObject desireObject)
        => desireObject.SetActive(false);

    private void CloseAllPanel ()
    {
        questionPannel.SetActive(false);
        informationPannel.SetActive(false);
    }
}
