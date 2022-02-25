using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Canvas portalTxt;
    
    private LevelLoader levelLoader;

    private void Start()
    {
        SetPortalTxtVisibility(false);
        levelLoader = GetComponent<PortalLevelLoader>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player") SetPortalTxtVisibility(true);;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name != "Player") return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E");
            levelLoader.LoadScene();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        SetPortalTxtVisibility(false);
    }

    void SetPortalTxtVisibility(bool state) => portalTxt.enabled = state;
}