data_way = r'C:\Users\USER\Desktop\Geekbrains\Prog\Python\Lesson_8\seminar_8\base.txt'

contact = 'иванов иван иванович'

def add_contact(contact):
    with open(data_way, 'a', encoding="utf-8") as base:
        base.write(f'\n {contact}')

def read_base(data_way):
    with open(data_way, 'r', encoding="utf-8") as base:
        print(base.read())

def search_base(data_way, arg):
    with open(data_way, 'r', encoding="utf-8") as base:
        for line in base:
            if arg in line:
                print(line)

read_base(data_way)
# search_base(data_way, "kg")