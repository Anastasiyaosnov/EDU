# Дана последовательность из N целых чисел и число K.
# Необходимо сдвинуть всю последовательность (сдвиг циклический) на K элементов вправо
# [1,2,3,4,5] при к = 3 -> [3, 4 , 5, 1, 2]

n = [1,2,3,4,5]
k = 3
massive = []

# Мой не очень умный вариант. Но вот так я смогла решить

'''

if k%len(n)!=0:
    k = k%len(n)
else:
    k = len(n)
for i in n[-k::]:
    massive.append(i)
for i in range(0,(len(n)-k)):
    massive.append(n[i])
print(massive)
print(k)

'''

# Уже не мой, но очень умный вариант

if k%len(n)!=0:
    k = k%len(n)
else:
    k = len(n)
for i in range(k):
    n.insert(0,n.pop(-1))

print(n)