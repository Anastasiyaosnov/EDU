# 3. В некоторой школе решили набрать три новых математических класса
# и оборудовать кабинеты для них новыми партами.
# За каждой партой может сидеть два учащихся.
# Известно количество учащихся в каждом из трех классов.
# Выведите наименьшее число парт, которое нужно приобрести для них.

# **Input:**
# 20
# 21
# 22

# **Output:**
# 32


first = int(input('Введите количество учеников в 1 классе: '))
second = int(input('Введите количество учеников в 2 классе: '))
third = int(input('Введите количество учеников в 3 классе: '))

sum = (first+1)//2+(second+1)//2+(third+1)//2

print(sum)