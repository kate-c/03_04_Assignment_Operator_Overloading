﻿using System;

/*
Источник: https://metanit.com/

Класс Celcius представляет градусник по Цельсию, а Fahrenheit - градусник по Фаренгейту.
Определите операторы преобразования от типа Celcius и наоборот.
Преобразование температуры по шкале Фаренгейта (Tf) в температуру по шкале Цельсия (Tc): Tc = 5/9 * (Tf - 32).
Преобразование температуры по шкале Цельсия в температуру по шкале Фаренгейта: Tf = 9/5 * Tc + 32.

Тестирование приложения выполняется путем запуска разных наборов тестов, например,
на вход поступает две строки - количество градусов в Фаренгейтах и количество градусов в Цельсиях.
50
50
Программа должна вывести на экран число градусов в Цельсиях и Фаренгейтах, соответственно
с использованием перегруженных операторов (округлять до 2 знаков после запятой):
10
122

Никаких дополнительных символов выводиться не должно.

Код метода Main можно подвергнуть изменениям, но вывод меняться не должен.
*/

namespace Task04
{
    class Celcius
    {
        public double Gradus { get; set; }
    }

    class Fahrenheit
    {
        public double Gradus { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

        }
    }
}