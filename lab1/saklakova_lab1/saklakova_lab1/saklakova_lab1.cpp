// saklakova_lab1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;
//При запуске программы выводится меню, запрашивающее в бесконечном цикле действие от пользователя.Пример меню : 
1. Добавить трубу 
2. Добавить КС 
3. Просмотр всех объектов 
4. Редактировать трубу 
5. Редактировать КС 
6. Сохранить 
7. Загрузить 
//0. Выход
void printed() 
{
cout << "1.Add pipe
	2. Add compressor station"
}
	





void main()
{
	struct truba {
		string truba_name;
		double len;
		double diam;
		bool rem;
	} truba;

	struct ks {
		string ks_name;
		double efc;
		int ws;
		int wws;
	} ks;
}
