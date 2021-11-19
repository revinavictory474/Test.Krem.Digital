using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DestroyBuilding
{
    internal class CounterTrigger : MonoBehaviour
    {
        #region Fields
        private const int HUNDRED = 100;

        [SerializeField] private Slider _progressBar;
        [SerializeField] private TextMeshProUGUI _textMesh;
        [SerializeField] private VisibleBlockController[] _blocks;

        private PiecesCount[] _pieces;

        private float _correctAmountBlock;
        private float _countBlock;
        internal float _percent;
        private int _currentTextScore;
        #endregion

        private void Awake()
        {
            GetCorrectAmountBlock();
        }

        private void Update()
        {
            SetCorrectValueProgressBar();
            SetCorrectValueTextBar();
        }

        /// <summary>
        /// ������� ����� ���������� �������� �� �����, ����������� ��� 100% ����������� ����
        /// </summary>
        /// <returns></returns>
        private float GetCorrectAmountBlock()
        {
            for (int i = 0; i < _blocks.Length; i++)
            {
                _pieces = _blocks[i].GetComponentsInChildren<PiecesCount>();

                for (int j = 0; j < _pieces.Length; j++)
                {
                    _correctAmountBlock++;
                }
            }

            return _correctAmountBlock;
        }

        /// <summary>
        /// ���������� 1 ���� � �������� ����������� ������ ��� ��������������� � ��������� �� �����
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Block"))
            {
                _countBlock++;
            }
        }

        /// <summary>
        /// ���� ���������� ����������� ������ ������ ��� ����� ����, ������ �� ������. 
        /// ���� �� ���������� ������ 0, �� ��������� ������� ��������� � ������� ��� �������� � �����������.
        /// ���� ������� ������ 1, �� ������������� �������� 1.
        /// </summary>
        private void SetCorrectValueProgressBar()
        {
            if (_countBlock <= 0)
                return;
            else if (_countBlock > 0)
            {
                CalculationPercent();

                if (_percent >= 1) _percent = 1;
            }
            _progressBar.value = _percent;
        }

        /// <summary>
        /// ������� �������� ��������� � ��������� ���� �� �������� ����.
        /// </summary>
        private void SetCorrectValueTextBar() =>
            _textMesh.text = (ConvertingNumberToFormatInt() + "%").ToString();

        /// <summary>
        /// �������� ������������ ������� �� 100 � �������� ����� ����� ������� ��� ������������� ���������� � ��������� ������� (������� � �����).
        /// </summary>
        private int ConvertingNumberToFormatInt()
        {
            _currentTextScore = Mathf.RoundToInt(_percent * HUNDRED);
            return _currentTextScore;
        }
        
        /// <summary>
        /// ���������� �������� ��������� 
        /// </summary>
        private void CalculationPercent() =>
            _percent = _countBlock / _correctAmountBlock;
    }
}