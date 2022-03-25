using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Canvas portalTxt;

    private void Start()
    {
        SetPortalTxtVisibility(false);
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
        }
    }

    private void OnTriggerExit(Collider other)
    {
        SetPortalTxtVisibility(false);
    }

    void SetPortalTxtVisibility(bool state) => portalTxt.enabled = state;
}