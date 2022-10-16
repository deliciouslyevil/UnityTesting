using UnityEngine;
public class scrollZoom : MonoBehaviour
{
    // Movement based Scroll Wheel Zoom.
    public Transform parentObject;
    public float zoomLevel;
    public float sensitivity=1;
    public float speed;
    public float maxZoom;
    float zoomPosition;
    void Update()
    {
        zoomLevel += Input.mouseScrollDelta.y * sensitivity;
        zoomLevel = Mathf.Clamp(zoomLevel, 0, maxZoom);
        zoomPosition = Mathf.MoveTowards(zoomPosition, zoomLevel, speed * Time.deltaTime);
        transform.position = parentObject.position + (transform.forward * zoomPosition);
    }
}
