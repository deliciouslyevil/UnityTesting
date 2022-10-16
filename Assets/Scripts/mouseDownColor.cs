using UnityEngine;

public class mouseDownColor : MonoBehaviour
{
    private Renderer _renderer;
    public Color custom_green;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Click!");
        Color custom_magenta = new Color32( 255, 0, 255, 255 );
//https://docs.unity3d.com/ScriptReference/Color.html

        if (_renderer.material.color == Color.red){
          Debug.Log("I'm Red!");
          _renderer.material.color = Color.blue;
          Debug.Log("I changed Blue!");
        }
        else if (_renderer.material.color == Color.blue){
          Debug.Log("I'm Another Blue!");
          _renderer.material.color = custom_magenta;
          Debug.Log("I changed magenta!");
        }
        else if (_renderer.material.color == custom_magenta){
          Debug.Log("I'm magenta!");
          _renderer.material.color = custom_green;
          Debug.Log("I changed green!");
        }
        else{
          Debug.Log("I'm green!");
          _renderer.material.color = Color.red;
          Debug.Log("I changed red!");
        }

/*short form--
        _renderer.material.color =
        _renderer.material.color == Color.red ? Color.blue : Color.red;*/
    }
}
