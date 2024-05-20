using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHealth : HealthManager
{
  public override void TakeDamage(Vector3 location, Vector3 direction, float damage, Collider bodyPart = null, GameObject origin = null)
  {
   this.GetComponent<Rigidbody>().AddForce(direction * 5f, ForceMode.Impulse);
  }
}
