using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DestroyBuilding
{
    internal class GameManager : MonoBehaviour
    {
        #region Fields
        private const float PERCENTTOWIN = 0.7f;
        private const float TIMETOLOSE = 22.0f;

        [SerializeField] private GameObject _winWindow;
        [SerializeField] private GameObject _loseWindow;
        [SerializeField] private CounterTrigger _counter;
        [SerializeField] private TextMeshProUGUI _timerToEndGame;

        private float _timerToLose = TIMETOLOSE;
        #endregion

        private void Start()
        {
            Time.timeScale = 1;
        }

        private void Update()
        {
            ShowWinWindow();
            ShowLoseWindow();
            ShowTimerToEndGame();
        }

        /// <summary>
        /// ������������� �������
        /// </summary>
        public void RestartLevel()
        {
            SceneManager.LoadScene(0);
        }

        /// <summary>
        /// �������� ���� � ��������� ��� ���������� 70% ������ � ��������������� ��������
        /// </summary>
        private void ShowWinWindow()
        {
            if (_counter._percent >= PERCENTTOWIN && _timerToLose >= 0)
            {
                _winWindow.SetActive(true);
                Time.timeScale = 0;
            }
        }

        /// <summary>
        /// �������� ���� � ���������� ��� ������������� ������� � ������� ����� 70%
        /// </summary>
        private void ShowLoseWindow()
        {
            if (_timerToLose <= 0 && _counter._percent < PERCENTTOWIN)
            {
                _loseWindow.SetActive(true);
                Time.timeScale = 0;
            }
        }

        private void ShowTimerToEndGame()
        {
            _timerToEndGame.text = DecreaseTimer().ToString();
        }

        private int DecreaseTimer()
        {
            _timerToLose -= Time.deltaTime;

            return Mathf.RoundToInt(_timerToLose);
        }
    }
}