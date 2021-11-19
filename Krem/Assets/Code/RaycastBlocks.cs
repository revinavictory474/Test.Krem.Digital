using UnityEngine;

namespace DestroyBuilding
{
    internal class RaycastBlocks : MonoBehaviour
    {
        #region Fields
        [SerializeField] private VisibleBlockController[] _visibleController;
        [SerializeField] private GameObject _explosion;
        #endregion

        private void Update()
        {
            Raycasting();
        }

        /// <summary>
        /// О0сновная логика приложения, где мы выпускаем луч, смотрим с чем он столкнулся, подменяем блоки, создаем взрыв.
        /// </summary>
        private void Raycasting()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    for (int i = 0; i < _visibleController.Length; i++)
                    {
                        if (_visibleController[i].transform.position == hit.transform.position)
                        {
                            SwapBlocks(i);
                            CreateExplosion(hit.transform);
                            Handheld.Vibrate();
                        }
                    }

                    var rigidbodyBlock = hit.collider.GetComponent<Rigidbody>();

                    if (rigidbodyBlock != null)
                    {
                        AddForceRigidbody(rigidbodyBlock, ray, hit);
                        CreateExplosion(rigidbodyBlock.transform);
                    }
                }
            }
        }

         /// <summary>
         /// Создаем эффект взрыва
         /// </summary>
         /// <param name="transform"></param>
        private void CreateExplosion(Transform transform) =>
            Instantiate(_explosion, transform.transform.position, _explosion.transform.rotation);

        /// <summary>
        /// Придаём физическую силу блокам, расталкивая их
        /// </summary>
        /// <param name="rigidbody">Твердое тело блоков</param>
        /// <param name="ray">Луч</param>
        /// <param name="raycast">Столкновение луча с блоком</param>
        private void AddForceRigidbody(Rigidbody rigidbody, Ray ray, RaycastHit raycast)=>
            rigidbody.AddForceAtPosition(ray.direction * 100.0f, raycast.point, ForceMode.VelocityChange);

        /// <summary>
        /// Подменяем цельный блок на разбитый
        /// </summary>
        /// <param name="index"></param>
        private void SwapBlocks(int index) =>
            _visibleController[index].SendMessage("SetVisiblePiecesBlock");
    }
}