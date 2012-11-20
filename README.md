eventsourcing
=============

This is an open-source framework which implement the event sourcing pattern and CQRS architecture and is suitable for developing DDD based applications.

1. ����Դ����ǰ��ִ������build nuget�Ի�ȡ�ⲿ�����ĳ��򼯡����岽�裺�ڵ�ǰREADME.md�ļ�����Ŀ¼����סshit����Ȼ������Ҽ����ڵ����Ĳ˵�����ѡ���ڴ˴�������ڡ���Ȼ�����룺build nuget��Ȼ��س����ɡ�ע�⣺���Ŀ¼�в��ܰ����ո񣬷�������
2. ���Ҫ���Դ��룬��Ҫ���½�һ��SQL���ݿ⣬�������ƽ�EventSourcingSampleDB��Ȼ�����½������ݿ���ִ��SQL�ű���scripts\TableGenerateSQL.sql
3. �޸����ݿ������ַ����������ļ�Ŀ¼��src\Sample\EventSourcing.Sample.Test\ConfigFiles\Debug\nhibernate.config���޸��ļ���key=connection.connection_string������ֵ����
4. ���д���ǰ��Ҫ��װMSMQ������ᱨ��Ҫ��װMSMQ�ܼ򵥣����������->���г���->������ر�Windows���ܣ�Ȼ��ѡ��MSMQ���а�װ���ɡ�

����˵����
Sample��EventSourcing.Sample.Test��EventSourcing.Sample.Host���������̶��Ƕ���Ӧ�á�
EventSourcing.Sample.Test�����Ե�Ԫ���Եķ�ʽ����������ģ��ִ��ҵ���߼�������Event Sourcingģʽ�еĿ���Դ�¼���
EventSourcing.Sample.Host��һ����������̨Ӧ�ó�����Ϊ�첽�¼����ߵ��¼������߶˵㣬�������첽�ķ�ʽ������Test���̲����Ŀ���Դ�¼���

�������д���ʱ�������ϣ��CQRS�ܹ��е���ʾ���ж������ݣ�����Ҫ������Test����ǰ������EventSourcing.Sample.Host�������̨Ӧ�ó���


## License

![GPL](http://www.gnu.org/graphics/gplv3-127x51.png)

	[GPL](http://www.gnu.org/copyleft/gpl.html)
	

	Copyright (C) 2012  CodeSharp

	This program is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program.  If not, see <http://www.gnu.org/licenses/>.