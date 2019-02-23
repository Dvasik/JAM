using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Screame : MonoBehaviour
{
  public AudioClip screamS;
  public Material screamImage;
  public Material normalImage;
  void OnCollisionEnter(Collision ScreamTrigger)
  {
    if (ScreamTrigger.gameObject.name == "Player")
    {
      gameObject.GetComponent<Renderer>().material = screamImage;
      AudioSource.PlayClipAtPoint(screamS, transform.position);
      Debug.Log("NOOOOOOOP");
    }
  }
  void OnCollisionExit(Collision ScreamTrigger)
  {
    gameObject.GetComponent<Renderer>().material = normalImage;
  }
}
