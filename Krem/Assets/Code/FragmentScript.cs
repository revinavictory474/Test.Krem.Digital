using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentScript : MonoBehaviour
{
	public bool isdead = false; //переменная которая обозначает разрушился объект, или еще нет
	public float timeRemaining = 100;//время после которого должен удалится объект после разрушения (сделано во благо оптимизации)
	public Rigidbody rbBlock;
	private float explosionForce = 5.0f;


	void Start()
	{
		rbBlock = GetComponent<Rigidbody>();
		//rbBlock.isKinematic = true;//включаем у риджидбоди синематик дабы наш объект не разрушался раньше времени
	}

    //void RayCast()//проверяем на объект на коллизию
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
    //            //GetComponent<Rigidbody>().isKinematic = false;//и если он с чем-то столкнулся, отключаем синематик тем самым разрушая его
    //            //isdead = true;//делаем переменную положительной, чтобы скрипт смог понять что обьект уже "отработан", и его можно удалить
    //        }
    //    }
    //}

    void Update()
	{
		


		//RayCast();


		//if (isdead)//если переменная положительная, то запускаем таймер 
		//{
		//	timeRemaining -= Time.deltaTime;//сам таймер			

		//	if (timeRemaining < 0) //и если время таймера меньше нуля, то 
		//	{
		//		Destroy(gameObject);//просто удаляем объект
		//	}
		//}
	}

	
}
