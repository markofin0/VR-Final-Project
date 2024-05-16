using UnityEngine;

public class PortalController : MonoBehaviour
{
    public void DestroyPortal()
    {
        // old script, used to be used to destroy duolicate portals, now sits as reference for previous commits
        Destroy(gameObject);
    }
}
