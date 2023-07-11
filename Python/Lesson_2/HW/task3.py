'''
Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.
Пример:
10 -> 1 2 4 8

'''
UserValue = int(input("Введите целое положительное число: "))
value = 1
while value <= UserValue:
    print(f"{value} ")
    value = 2*value
