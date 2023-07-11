'''
Задача 1: Найдите сумму цифр трехзначного числа.
123 -> 6 (1 + 2 + 3)
100 -> 1 (1 + 0 + 0)
'''

UserValue = int(input("Введите целое число: "))
sum = 0
while UserValue>0:
    sum += UserValue%10
    UserValue=int(UserValue/10)
print(sum)