using SystemCollections;
using SystemCollections.Generic;
using UnityEngine;
using Photon.VR;
namespace PVRServers

public class PhotonRoom1 : MonoBehaviour
{
public string Handtag;
public string roomCode;
void OnTriggerEnter(Collider other)
 {
   if (other.transform.tag == Handtag)
//Join server code that you put in the public string.
string roomCode == roomCode
PhotonVRManager.JoinPrivateRoom(roomCode);
  }
 }
}
