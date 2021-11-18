using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleBlockController : MonoBehaviour
{
    [SerializeField] private GameObject _bigBlock;
    [SerializeField] private GameObject[] _piecesBlock;

    public VisibleBlockController(GameObject bigBlock, GameObject[] piecesBlock)
    {
        _bigBlock = bigBlock;
        _piecesBlock = piecesBlock;
    }

    public void SetVisiblePiecesBlock()
    {
        _bigBlock.SetActive(false);
        
        for(int i = 0; i < _piecesBlock.Length; i++)
        {
            _piecesBlock[i].SetActive(true);
        }
    }
}
