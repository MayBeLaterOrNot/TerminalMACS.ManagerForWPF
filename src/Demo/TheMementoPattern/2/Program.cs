//using System;

//namespace TheMementoPattern._2
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			// Originator��ʼ״̬��״̬����Ϊ��On��
//			Originator o = new Originator();
//			o.State = "On ";
//			o.Show();


//			Caretaker c = new Caretaker();

//			// ����״̬ʱ���������˺ܺõķ�װ����������Originator��ʵ��ϸ��
//			c.Memento = o.CreateMemento();

//			// Originator�ı���״̬����Ϊ��Off��
//			o.State = "off";
//			o.Show();

//			// �ָ�ԭ��ʼ״̬
//			o.SetMemento(c.Memento);
//			o.Show();

//			Console.Read();
//		}
//	}
//}

