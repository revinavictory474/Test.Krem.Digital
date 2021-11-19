using UnityEngine;

namespace DestroyBuilding
{
	internal class DestroyExplosion : MonoBehaviour
	{
        #region Fields
        private const float TIMEDESTROY = 3.0f;

		private float _timeToDestroy = TIMEDESTROY;
        #endregion

        void Update()
		{
			Destroy();
		}

		/// <summary>
		/// Удалить эффект взрыва со сцены по истечении таймера.
		/// </summary>
		private void Destroy()
		{
			_timeToDestroy -= Time.deltaTime;

			if (_timeToDestroy <= 0) Destroy(gameObject);
		}
	}
}