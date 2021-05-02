using System;

namespace TheMementoPattern._3
{
	class Program
	{
		static void Main(string[] args)
		{
			// ��սBossǰ
			GameRole lixiaoyao = new GameRole();

			// ��Ϸ��ɫ��ʼ״̬������ָ�����ݶ���100
			lixiaoyao.GetInitState();
			lixiaoyao.StateDisplay();

			// �������
			RoleStateCaretaker stateAdmin = new RoleStateCaretaker();

			// �������ʱ�����ڷ�װ��Memento�У�������ǲ���֪����������Щ����Ľ�ɫ����
			stateAdmin.Memento = lixiaoyao.SaveState();
			
			// ��սBossʱ���������
			// ��ʼ��սBoss������ָ�����ݶ��½��ܶ࣬�ǳ���⣬GameOver��
			lixiaoyao.Fight();
			lixiaoyao.StateDisplay();


			// �ָ�֮ǰ״̬
			// ���У��ָ������״̬����������
			lixiaoyao.RecoveryState(stateAdmin.Memento);
			lixiaoyao.StateDisplay();

			Console.Read();
		}
	}
}
