//using System;

//namespace TheMementoPattern._1
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			// ��սBossǰ
//			GameRole lixiaoyao = new GameRole();

//			// ��սBossǰ����ó�ʼ��ɫ״̬
//			lixiaoyao.GetInitState();
//			lixiaoyao.StateDisplay();

//			//�������
//			GameRole backup = new GameRole();

//			// ͨ������Ϸ��ɫ������ʵ�������������
//			backup.Vitality = lixiaoyao.Vitality;
//			backup.Attack = lixiaoyao.Attack;
//			backup.Defense = lixiaoyao.Defense;

//			//��սBossʱ���������
//			lixiaoyao.Fight();

//			// ��սBoss ʱ, ���������������ȫ�����Ϊ��
//			lixiaoyao.StateDisplay();

//			//�ָ�֮ǰ״̬,GameOver������,�ָ�֮ǰ���ȣ���������
//			lixiaoyao.Vitality = backup.Vitality;
//			lixiaoyao.Attack = backup.Attack;
//			lixiaoyao.Defense = backup.Defense;
//			lixiaoyao.StateDisplay();

//			Console.Read();
//		}
//	}
//}

