eventsourcing
=============

This is an open-source framework which implement the event sourcing pattern and CQRS architecture and is suitable for developing DDD based applications.

1. ����Դ����ǰ��ִ������build nuget�Ի�ȡ�ⲿ�����ĳ��򼯡����岽�裺�ڵ�ǰREADME.md�ļ�����Ŀ¼����סshit����Ȼ������Ҽ����ڵ����Ĳ˵�����ѡ���ڴ˴�������ڡ���Ȼ�����룺build nuget��Ȼ��س����ɡ�ע�⣺���Ŀ¼�в��ܰ����ո񣬷�������
2. ���Ҫ���Դ��룬��Ҫ���½�һ��SQL���ݿ⣬�������ƽ�EventSourcingSampleDB��Ȼ�����½������ݿ���ִ��SQL�ű���scripts\TableGenerateSQL.sql
3. �޸����ݿ������ַ����������ļ�Ŀ¼��\src\Sample\EventSourcing.Sample.Test\ConfigFiles\Debug\eventsourcing.config���޸��ļ���key=connectionString������ֵ����
4. ���д���ǰ��Ҫ��װMSMQ������ᱨ��Ҫ��װMSMQ�ܼ򵥣����������->���г���->������ر�Windows���ܣ�Ȼ��ѡ��MSMQ���а�װ���ɡ�
5. ���Ҫ�����첽�¼���Ӧ���ܣ���Ҫ����EventSourcing.Sample.Host��ͬ������ǰ��Ҫ�޸����ݿ������ַ������ڸù�������Ŀ¼��ConfigFiles\Debug��Ŀ¼�¡�
6. Ŀǰ�ṩ���ĸ�sample����������ͬ���¼���Ӧ��Order��MoneyTransfer�������������첽�¼���Ӧ��Forum��BookBorrowAndReturn����������ο����롣

����˵����
Sample��EventSourcing.Sample.Test��EventSourcing.Sample.Host���������̶��Ƕ���Ӧ�á�
EventSourcing.Sample.Test�����Ե�Ԫ���Եķ�ʽ����������ģ��ִ��ҵ���߼�������Event Sourcingģʽ�еĿ���Դ�¼���
EventSourcing.Sample.Host��һ����������̨Ӧ�ó�����Ϊ�첽�¼����ߵ��¼������߶˵㣬�������첽�ķ�ʽ������Test���̲����Ŀ���Դ�¼���

�������Order��MoneyTransfer��������Ԫ�����ļ�������������Host���̣�
�������Forum��BookBorrowAndReturn��������Ԫ�����ļ�������Ҫ����Host���̣�������ʾ���н����������ݣ�


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