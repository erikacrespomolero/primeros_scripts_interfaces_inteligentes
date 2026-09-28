using UnityEngine;

public class DistanceCubeCylinder : MonoBehaviour {
  void Start() {
    Vector3 positionCube = GameObject.FindWithTag("cube").transform.position;
    float distance = Vector3.Distance(positionCube, transform.position);
    Debug.Log("Distance sphere and cube: " + distance);
    Vector3 positionCylinder = GameObject.FindWithTag("cylinder").transform.position;
    distance = Vector3.Distance(positionCylinder, transform.position);
    Debug.Log("Distance sphere and cylinder: " + distance);
  }
}
