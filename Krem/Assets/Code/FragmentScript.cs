using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentScript : MonoBehaviour
{
	public bool isdead = false; //���������� ������� ���������� ���������� ������, ��� ��� ���
	public float timeRemaining = 100;//����� ����� �������� ������ �������� ������ ����� ���������� (������� �� ����� �����������)
	public Rigidbody rbBlock;
	private float explosionForce = 5.0f;


	void Start()
	{
		rbBlock = GetComponent<Rigidbody>();
		//rbBlock.isKinematic = true;//�������� � ���������� ��������� ���� ��� ������ �� ���������� ������ �������
	}

    //void RayCast()//��������� �� ������ �� ��������
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            if (hit.collider.tag == "Block")
    //            {
    //                rbBlock.isKinematic = false;
    //                rbBlock.AddExplosionForce(explosionForce, Vector3.up, 10.0f);
    //            }
    //            //GetComponent<Rigidbody>().isKinematic = false;//� ���� �� � ���-�� ����������, ��������� ��������� ��� ����� �������� ���
    //            //isdead = true;//������ ���������� �������������, ����� ������ ���� ������ ��� ������ ��� "���������", � ��� ����� �������
    //        }
    //    }
    //}

    void Update()
	{
		


		//RayCast();


		//if (isdead)//���� ���������� �������������, �� ��������� ������ 
		//{
		//	timeRemaining -= Time.deltaTime;//��� ������			

		//	if (timeRemaining < 0) //� ���� ����� ������� ������ ����, �� 
		//	{
		//		Destroy(gameObject);//������ ������� ������
		//	}
		//}
	}

	
}
