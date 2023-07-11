'''
1. По данному целому неотрицательному n вычислите значение n!.
N! = 1 * 2 * 3 * … * N (произведение всех чисел от 1 до N) 0! = 1
Решить задачу используя цикл while

'''

UserValue = int(input("Введите целое неотрицательное число: "))
counter = UserValue
factorial = 1
while counter > 0:
    factorial *=counter
    counter -= 1
print(factorial)
