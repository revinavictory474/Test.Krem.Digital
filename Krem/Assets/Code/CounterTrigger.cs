using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterTrigger : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;
    [SerializeField] private TextMeshProUGUI _textMesh;
    private PiecesCount[] _pieces;
    public  VisibleBlockController[] _blocks;

    public float _correctAmountBlock;
    public float _countBlock;
    public float _percent;

    private void Awake()
    {
        GetCorrectAmountBlock();
    }

    private void Update()
    {
        SetCorrectValueProgressBar();
        SetCorrectValueTextBar();
    }

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

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Block"))
        {
            _countBlock++;
        }
    }

    private void SetCorrectValueProgressBar()
    {
        if (_countBlock <= 0)
            return;
        else if(_countBlock > 0)
        {
            _percent = _countBlock / _correctAmountBlock;
        }
        _progressBar.value = _percent;
    }

    private void SetCorrectValueTextBar()
    {
        _textMesh.text = (_percent * 100 ).ToString();
    }
}
