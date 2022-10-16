using UnityEngine;

public class mouseDownIsolate : MonoBehaviour
{

    public GameObject[] gos;
    public bool state = false;

    private void OnMouseDown()
    {
      Debug.Log("Clicked!");
    GameObject current = this.gameObject;
      Debug.Log("The game object that this script is attached to is: " + current);
      if (state == false){
          Debug.Log("The state is false");
          foreach (GameObject go in gos){
              if (go != current){
                  go.SetActive (false);
                  Debug.Log(go + "is turning off");
                }
          }
      }
      else{
        Debug.Log("The state is true");
        foreach (GameObject go in gos) {
                go.SetActive (true);
                Debug.Log(go + "is turning on");

        }
      }
    state = !state;
    Debug.Log("changed state to" + state);
    }
  }
