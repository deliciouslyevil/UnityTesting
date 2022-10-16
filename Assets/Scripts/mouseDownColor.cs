using UnityEngine;

public class mouseDownColor : MonoBehaviour
{
    private Material _myMaterial;
    public Color custom_green;
    public Color custom_magenta;

    private void Start()
    {
        _myMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseDown()
    {
        Debug.Log("Click!");

//https://docs.unity3d.com/ScriptReference/Color.html

        if (_myMaterial.color == Color.red){
          Debug.Log("I'm Red!");
          _myMaterial.color = Color.blue;
          Debug.Log("I changed Blue!");
        }
        else if (_myMaterial.color == Color.blue){
          Debug.Log("I'm Another Blue!");
          _myMaterial.color = custom_magenta;
          Debug.Log("I changed magenta!");
        }
        else if (_myMaterial.color == custom_magenta){
          Debug.Log("I'm magenta!");
          _myMaterial.color = custom_green;
          Debug.Log("I changed green!");
        }
        else{
          Debug.Log("I'm green!");
          _myMaterial.color = Color.red;
          Debug.Log("I changed red!");
        }

/*short form--
        _renderer.material.color =
        _renderer.material.color == Color.red ? Color.blue : Color.red;*/
    }
}
