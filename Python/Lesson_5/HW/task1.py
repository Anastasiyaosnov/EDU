# Задача 1
# Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
# A = 3; B = 5 -> 243 (3⁵)
# A = 2; B = 3 -> 8


def exponentation(first, second):
    if (second == 1):
        return first
    if (second != 1):
        return (first * exponentation(first, second - 1))
first = int(input("Введите число: "))
second = int(input("Введите степень числа: "))
print(f"Результат возведения в степень равен: {exponentation(first, second)}")

