using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
	private float _timeToDestroy = 5.0f;

    void Update()
	{
		Destroy();
	}

	private void Destroy()
    {
		_timeToDestroy -= Time.deltaTime;

		if (_timeToDestroy <= 0) Destroy(gameObject);
    }
}
