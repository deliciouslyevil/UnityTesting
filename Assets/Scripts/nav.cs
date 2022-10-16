using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class nav : MonoBehaviour
{

  [SerializeField]
  private int _counter =0;
  public GameObject forBtn;
  public GameObject revBtn;
  public GameObject leftBrain;
  public GameObject rightBrain;
  public TextMeshProUGUI moduleText;

  public Color green;
  public Color pink;
  private GameObject occipital;
  public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
      occipital = GameObject.Find("OccipitalLobe_R");
    }

    public void forNav(){
      _counter ++;
      if(_counter == 3){
        _counter = 0;
      }
      navigation();
        }
    public void revNav(){
      _counter --;
      navigation();
    }

  void navigation()
  {




      switch (_counter)
      {
      case 0:
          print ("Level 1");
          leftBrain.SetActive(true);
          rightBrain.SetActive(true);
          revBtn.SetActive(false);
          moduleText.text = "Look at the basic interactivity and navigation and how it's set up.";

          foreach (GameObject go in GameObject.FindGameObjectsWithTag("Parts"))
          {
          go.GetComponent<Renderer>().material.color = pink;
          }
          controller.GetComponent<SelectParts>().enabled = false;
          break;
      case 1:
          print ("Level 2");
          leftBrain.SetActive(false);
          revBtn.SetActive(true);
          moduleText.text = "Welcome to level 2.  In this one we're using the mesh colliders on all the objects to detect a raycast.  When hit they change color, and the name of the object appears.  Could you also add descriptions for the objects?";
          controller.GetComponent<IsolateSections>().enabled = false;
          controller.GetComponent<SelectParts>().enabled = true;
          break;

      case 2:
          print ("Level 3.  Here we're isolating the parent of the clicked object to look at groups on their own.");
          foreach (GameObject go in GameObject.FindGameObjectsWithTag("Parts"))
          {
          go.GetComponent<Renderer>().material.color = pink;
          }
          moduleText.text = "Welcome to level 3";
          controller.GetComponent<SelectParts>().enabled = false;
          controller.GetComponent<IsolateSections>().enabled = true;
            forBtn.SetActive(true);
          break;

      case 3:
        forBtn.SetActive(false);
        break;

      default:
          print ("Error");
          break;
      }
  }
    }
