using UnityEngine;

public class mouseDownAlpha : MonoBehaviour
{

    private Material _myMaterial;
    private Color _myColor;

    private void Start()
    {
        _myMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseDown()
    {
        Debug.Log("Click!");
        _myColor = _myMaterial.color;

//https://docs.unity3d.com/ScriptReference/Color.html

        if (_myColor.a == 1){
          Debug.Log(_myMaterial.color.a + "I'm Opaque!");
          _myColor.a = 0.5f;
          Debug.Log(_myMaterial.color.a + "I'm Still Opaque!");
          _myMaterial.color = _myColor;
          Debug.Log(_myColor.a + "I'm now Transparent!");
        }

        else{
          Debug.Log("I'm Transparent!");
          _myColor.a = 1.0f;
          Debug.Log(_myMaterial.color.a + "I'm Still Transparent!");
          _myMaterial.color = _myColor;
          Debug.Log(_myColor.a + "I'm now Opaque!");
        }
    }
}
