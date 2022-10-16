using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IsolateSections : MonoBehaviour
{
  [SerializeField]
  private GameObject[] _gos;
  [SerializeField]
  private bool _state = false;
  private GameObject _current;
  public string objTag;
  public TextMeshProUGUI label_txt;

  private void Start()
  {
      _gos = GameObject.FindGameObjectsWithTag(objTag);
  }

  void Update(){
   if (Input.GetMouseButtonDown(0)){
     CastRay();
   }
  }

  public void CastRay(){
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if (Physics.Raycast(ray, out hit)) {
      if (hit.collider.tag == objTag){
        _current = hit.collider.gameObject.transform.parent.gameObject;
        if (_state == false){
          foreach (GameObject go in _gos) {
            if (go.transform.parent.gameObject != _current){
            go.transform.parent.gameObject.SetActive(false);
          }
          label_txt.text = _current.name;
          _state = true;
        }
      }
        else{
          foreach (GameObject go in _gos) {
          go.transform.parent.gameObject.SetActive(true);
          }
          _state = false;
          label_txt.text = "The Brain";
          }
        }
      }
    }
}
