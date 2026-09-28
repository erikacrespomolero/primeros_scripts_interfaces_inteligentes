using UnityEngine;

public class ColorRandom : MonoBehaviour {
  public int frames;
  private int frameCounter = 0;

  void Update() {
    ++frameCounter;
    if (frameCounter >= frames) {
      frameCounter = 0;
      ChangeColor();
    }
  }
  
  void ChangeColor() {
    Renderer renderer = GetComponent<Renderer>();
    renderer.material.color = new Color(Random.value, Random.value, Random.value);
  }
}
