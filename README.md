
# Итоговая проверочная работа по первому блоку обучения

## **Задача: сформировать и вывести массив строк длиной не более 3-х символов из массива введенных строк**.

## *Состав работы (файлы репозитория):*
1. **PrintShortStrings_diagram.png** - блок-схема алгоритма;
2. **Program.cs** - файл программы на языке C#;
3. **TestStage01.csproj** - файл проекта;
4. **README.md** - описание выполнения задачи.

## *Описание алгоритма:*
1. пользователь указывает количество строк (**N**);
2. создается исходный одномерный массив строк **strings[]** размером **N**;
3. пользователь вводит строки одну за одной пока их количество не достигнет **N**; 
4. вместе с сохранением введенных строк в массив **strings[]**, алгоритм считает количество строк (в переменной **cntLen**) не длиннее предустановленного значения **maxLen**;
5. по завершении ввода строк алгоритм создает массив строк **strOut[]** размером **cntLen**;
6. итоговый массив **strOut[]** заполняется строками исходного массива **strings[]** по условию, что длина строки не превышает **maxLen**;
7. итоговый массив **strOut[]** печатается.

## *Описание программы:*
1. Метод **ReadDataToInt()** предлагает пользователю ввести количество строк, которое пользователь предполагает ввести далее, и сохраняет введенное значение в переменную **numOfStrings**; *далее*
2. Метод **ReadStringsToArray()** сохраняет строки, введенные пользователем в указанном количестве, в массив **inStrings[]**, используя метод считывания строк **ReadDataToString()**; *далее*
3. Метод **keepShortStrings()** формирует из исходного массива строк **inStrings[]** новый массив **outStrings[]**, содержащий только строки, содержащие не более 3-х символов (переменная **maxLen**); *далее*
4. Метод **Print1DArr()** выводит итоговый массив в консоль.
