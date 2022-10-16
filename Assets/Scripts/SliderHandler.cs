using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderHandler : MonoBehaviour
{
  public TextMeshProUGUI myText;
  public Slider mySlider;
  public Sprite[] sprites;
  public Image image;

  void Update() {

     myText.text = "Value: " + mySlider.value;
     int index = (int)mySlider.value;
     image.sprite = sprites[index];
  }
}
