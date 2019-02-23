using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Screame : MonoBehaviour
{
  public AudioClip screamS;
  public Material screamImage;
  void OnCollisionEnter(Collision ScreamTrigger)
  {
    if (ScreamTrigger.gameObject.name == "Cube")
    {
      gameObject.GetComponent<Renderer>().material = screamImage;
      AudioSource.PlayClipAtPoint(screamS, transform.position);
      Debug.Log("NOOOOOOOP");
    }
  }
}