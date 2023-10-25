using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextCountWarrior : MonoBehaviour
{
    [SerializeField] private CreateCharacter _countCharactrer;
    [SerializeField] private Text _textCountWarrior;

    void Start()
    {
        _textCountWarrior.text = _countCharactrer.CountWarrior.ToString();
    }



    public void UpdateCountWarrior()
    {
        _textCountWarrior.text = _countCharactrer.CountWarrior.ToString();
    }
}
