using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDownFadeTags : MonoBehaviour
{
  [SerializeField]
  private GameObject[] _gos;
  [SerializeField]
  private bool _state = false;

  private Color _myColor;
  private Material _myMaterial;
  private GameObject _current;
  public string objTag;

  private void Start()
  {
    _gos = GameObject.FindGameObjectsWithTag(objTag);
  }

  void Update(){
   if (Input.GetMouseButtonDown(0)){
     //Debug.Log("clicked!  Did I hit something?");
     CastRay();
   }
  }

  public void CastRay(){
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if (Physics.Raycast(ray, out hit)) {
      if (hit.collider.tag == objTag){
        Debug.Log("Hit " + hit.collider.gameObject.name);
        _current = hit.collider.gameObject;

        if (_state == false){
          foreach (GameObject go in _gos) {
            if (go != _current){
              _myMaterial = go.GetComponent<Renderer>().material;
              _myColor = _myMaterial.color;
              _myColor.a = 0.5f;
              _myMaterial.color = _myColor;
              _state = true;
            }
          }
        }
        else{
          if (_current.GetComponent<Renderer>().material.color.a != 1.0f){
            foreach (GameObject go in _gos) {
              _myMaterial = go.GetComponent<Renderer>().material;
              _myColor = _myMaterial.color;
              _myColor.a = 0.5f;
              _myMaterial.color = _myColor;
              _myColor.a = 1.0f;
            }
              _current.GetComponent<Renderer>().material.color = _myColor;
              _state = true;
          }
          else{
            foreach (GameObject go in _gos) {
              _myMaterial = go.GetComponent<Renderer>().material;
              _myColor = _myMaterial.color;
              _myColor.a = 1.0f;
              _myMaterial.color = _myColor;
              _state = false;
            }
          }
        }
      }
    }
  }
}
