using UnityEngine;

namespace DestroyBuilding
{
    internal class VisibleBlockController : MonoBehaviour
    {
        #region Fields
        [SerializeField] private GameObject _bigBlock;
        [SerializeField] private GameObject[] _piecesBlock;
        #endregion

        /// <summary>
        /// ������ ����� ���� �� ��������.
        /// </summary>
        internal void SetVisiblePiecesBlock()
        {
            _bigBlock.SetActive(false);

            for (int i = 0; i < _piecesBlock.Length; i++)
            {
                _piecesBlock[i].SetActive(true);
            }
        }
    }
}