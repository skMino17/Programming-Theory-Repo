using UnityEngine;

public class LightFollowMouse : MonoBehaviour
{
    [SerializeField] private float distanceFromCamera = 10f;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private LayerMask floorLayer;

    private Camera _mainCam;

    void Start()
    {
        _mainCam = Camera.main;

        if (_mainCam == null)
        {
            Debug.LogError("Hey! There is no camera tagged 'MainCamera' in the scene.");
        }
    }

    void Update()
    {
        if (_mainCam == null) return;

        Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f, floorLayer))
        {
            Quaternion targetRotation = Quaternion.LookRotation(hit.point - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothSpeed);
        }
    }
}