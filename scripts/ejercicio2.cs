using UnityEngine;

public class SphereProperties : MonoBehaviour{
  public Vector3 firstVector;
  public Vector3 secondVector;
  public float firstVectorMagnitude;
  public float secondVectorMagnitude;
  public float angle;
  public float distance;
  public string highVector;

  void Start() {
    PrintMagnitudes();
    PrintAngle();
    PrintDistance();
    PrintHigherVector();
  }

  void PrintMagnitudes() {
    firstVectorMagnitude = firstVector.magnitude;
    Debug.Log("Magnitude of first vector: " + firstVectorMagnitude);
    secondVectorMagnitude = secondVector.magnitude;
    Debug.Log("Magnitude of second vector: " + secondVectorMagnitude);
  }

  void PrintAngle() {
    angle = Vector3.Angle(firstVector, secondVector);
    Debug.Log("Angle between vectors: " + angle);
  }

  void PrintDistance() {
    distance = (firstVector - secondVector).magnitude;
    Debug.Log("Distance between vectors: " + distance);
  }

  void PrintHigherVector() {
    if (firstVector.y > secondVector.y) {
      highVector = "First vector is higher";
    } else if (secondVector.y > firstVector.y) {
      highVector = "Second vector is higher";
    } else {
      highVector = "Both vectors have the same magnitude";
    }
    Debug.Log(highVector);
  }
}
