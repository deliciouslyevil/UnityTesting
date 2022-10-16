using UnityEngine;

public class mouseDownIsolate : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _gos;
    [SerializeField]
    private bool _state = false;

    private void Start()
    {

    }

    private void OnMouseDown()
    {
    GameObject current = this.gameObject;

      if (_state == false){
          foreach (GameObject go in _gos) {
              if (go != current)
                  go.SetActive (false);
          }
      }
      else{
        foreach (GameObject go in _gos) {
                go.SetActive (true);
        }
      }
    _state = !_state;
    }
  }
