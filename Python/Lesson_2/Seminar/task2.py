'''

2.Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи оно является,
то есть выведите такое число n, что φ(n)=A.
Если А не является числом Фибоначчи, выведите число -1.
1 1 2 3 5 8
3 -> 4
5 -> 5
7 -> -1

'''

UserValue = int(input("Введите целое число, которое больше 1: "))
counter = 1
start = 0
first = 1
total = 0
while total < UserValue:
    total = start + first
    start = first
    first = total
    counter +=1

if total == UserValue:
    print(counter)
else:
    print(-1)


