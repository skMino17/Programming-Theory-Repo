using System.Collections;
using UnityEngine;

public class LightFollowMouse : MonoBehaviour
{
    [SerializeField] private float distanceFromCamera = 10f;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private LayerMask floorLayer;

    private Camera _mainCam;

    public static LightFollowMouse Instance; 
    private Light _lightComponent;

    void Awake()
    {
        Instance = this;
        _lightComponent = GetComponent<Light>();

        _lightComponent.enabled = false;
    }

    void Start()
    {
        _mainCam = Camera.main;
        StartCoroutine(DelayedPowerOn());
    }

    private IEnumerator DelayedPowerOn()
    {
        yield return new WaitForSeconds(1f);
        _lightComponent.enabled = true;
    }

    public void UpdateLightColor(Color newColor)
    {
        if (_lightComponent != null)
        {
            _lightComponent.color = newColor;
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