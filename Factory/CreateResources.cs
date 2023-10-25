using UnityEngine;
using UnityEngine.UI;

public class CreateResources : MonoBehaviour
{
    [SerializeField] private Text _wheatTextCount;


    private float _wheatHarvestTime = 1.0f;
    public float WheatHarvestTime { get { return _wheatHarvestTime; } }


    private int _wheatCount = 3;
    public int WheatCount { get { return _wheatCount; } }

    //������ ��������� ��������, ��� � �������� �������������� ������������ ���� �����-��, �� �� ������� ��������� �� ��� ����� (����� ������ ���������� ����� ���������)
    // ���� ���� ����� ���������� ����������, �������� ���������� 

    void Start()
    {
        _wheatTextCount.text = _wheatCount.ToString();
    }

    void Update()
    {

    }



    /////////////////////

    public void IncreasedWheatHarvestSpeed(float collectionSpeed)
    {
        _wheatHarvestTime += collectionSpeed;
    }

    public void DeleteWheat(int priceCharacter)
    {
        _wheatCount -= priceCharacter;
        if (_wheatCount < 0)
        {
            _wheatCount = 0;
            Debug.Log("������������� �������� �������!");
        }
        _wheatTextCount.text = _wheatCount.ToString();
    }

    public void AddResources(int typeResources)
    {
        typeResources++;
        _wheatTextCount.text = _wheatCount.ToString();
    }






























    //[SerializeField] private float _wheatHarvestTime;
    //[SerializeField] private Image _wheatReadyPanel;
    //[SerializeField] private Text _wheatTextCount;

    // int _wheatCount;
    ////��������� ����, ��� ���������� ? 

    ////������������, ��������� �������� ���� � ��������� ���� � �������� ����� ��������. ��� ������������ �������� ������������, ������� ���������� � ����� ����� � 6 ������

    //private float currentTime;


    //void Update()
    //{
    //    currentTime += Time.deltaTime;
    //    _wheatReadyPanel.fillAmount = currentTime / _wheatHarvestTime;

    //    if (currentTime >= _wheatHarvestTime)
    //    {
    //        currentTime = 0;
    //        _wheatReadyPanel.fillAmount = 0;

    //        AddWheat();
    //    }
    //    _wheatTextCount.text = WheatCount.ToString();
    //}

    //public void AddWheat()
    //{
    //    WheatCount++;
    //}
    //public void RemoveWheat(int countWheat)
    //{
    //    WheatCount -= countWheat;
    //}
}
