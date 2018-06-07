using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {
	public float health = 5;
	private bool isDead = false;

	void ApplyDamage(float damage)
	{
		health -= damage;	
		
		if(health <= 0 && !isDead)
		{
			isDead = true;
			Dying();
		}
		else
		{
			Damaging();
		}

		Debug.Log("health = " + health);
	}

	public virtual void Damaging()
	{		
	}
	
	public virtual void Dying ()
	{
	}
}
