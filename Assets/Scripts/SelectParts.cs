using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectParts : MonoBehaviour
{
  [SerializeField]
  private GameObject[] _gos;
  [SerializeField]
  private bool _state = false;

public Color pink;
public Color purple;
  private Material _myMaterial;
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
        Debug.Log("Hit " + hit.collider.gameObject.name);
        _current = hit.collider.gameObject;


                if (_state == false){
                  foreach (GameObject go in _gos) {
                    if (go != _current){
                    go.GetComponent<Renderer>().material.color= pink;

                    }
                    else{
                      go.GetComponent<Renderer>().material.color=purple;
                    }
                  }
                  label_txt.text = _current.name;
                  _state = true;
                }
                else{
                    if (_current.GetComponent<Renderer>().material.color==pink){
                      foreach (GameObject go in _gos) {
                        if (go != _current){
                            go.GetComponent<Renderer>().material.color= pink;
                          }
                        else{
                          go.GetComponent<Renderer>().material.color=purple;
                        }
                      }
                    _state = true;
                    label_txt.text = _current.name;
                    }
                  else{
                    foreach (GameObject go in _gos) {
                        go.GetComponent<Renderer>().material.color = pink;
                    }
                    _state = false;
                    label_txt.text = "The Brain";
                  }
                }

                }
              }
    }
}
