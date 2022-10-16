using UnityEngine;

public class mouseDownHighlight : MonoBehaviour
{
  private Material _myMaterial;
[SerializeField]
  private bool _state;

  private void Start()
  {
      _state = false;
  }

  private void OnMouseDown()
  {
      if (_state == false){
        Debug.Log("Not Highlighted");
        GetComponent<Outline>().enabled = true;
        Debug.Log("I'm Highlighted!");
      }

      else{
        Debug.Log("I'm Highlighted!");
          GetComponent<Outline>().enabled = false;
        Debug.Log("Not Highlighted");
      }
      _state = !_state;
  }
}
