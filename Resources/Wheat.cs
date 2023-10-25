using UnityEngine;
using UnityEngine.UI;

public class Wheat : MonoBehaviour
{
    [SerializeField] private float _wheatHarvestTime;
    [SerializeField] private Image _wheatReadyPanel;
    [SerializeField] private Text _wheatTextCount;

    public int WheatCount;
    //��������� ����, ��� ���������� ? 

    //������������, ��������� �������� ���� � ��������� ���� � �������� ����� ��������. ��� ������������ �������� ������������, ������� ���������� � ����� ����� � 6 ������

    private float currentTime;


    void Update()
    {
        currentTime += Time.deltaTime;
        _wheatReadyPanel.fillAmount = currentTime/_wheatHarvestTime;

        if (currentTime >= _wheatHarvestTime)
        {
            currentTime = 0;
            _wheatReadyPanel.fillAmount = 0;
            
            AddWheat();
        }
        _wheatTextCount.text = WheatCount.ToString();
    }

    public void AddWheat()
    {
        WheatCount++;
    }
    public void RemoveWheat(int countWheat)
    {
            WheatCount -= countWheat;
    }


}
