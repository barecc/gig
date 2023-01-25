Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Программа начинается с объявления двух массивов: один изначальный, второй с такой же длиной. Затем запускается метод, в котором используется цикл, соответствующий длине массива. Внутри цикла проверяется условие ( <=3 ), если оно выполняется, то элемент из первого массива заносится в элемент второго массива, соответствующий значению переменной count. Эта переменная используется для того, чтобы поочередно заносить элементы из первого массива во второй и избежать пробелов. После присвоения, переменная count увеличивается на 1 и возвращается к циклу for, в котором индекс i увеличивается на 1. И так происходит до конца массива.
