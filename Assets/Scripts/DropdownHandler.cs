using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownHandler : MonoBehaviour
{
public TextMeshProUGUI output;

  public void HandleInputData(int val){
    if (val == 0){
      output.text = "Discord is Selected";
    }
    if (val ==1){
      output.text = "Twitter is Selected";
    }
    if (val ==2){
      output.text = "Instagram is Selected";
    }
  }

}
