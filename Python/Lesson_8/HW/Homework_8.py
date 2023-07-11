# Дополнить телефонный справочник возможностью изменения и удаления данных.
# Пользователь также может ввести имя или фамилию, и Вы должны реализовать функционал для изменения и удаления данных

import os
import ast

contacts_file = r'D:\contacts.txt'

def read(file) -> dict:
    contacts_dict = {}
    with open(file, 'r', encoding="utf-8") as f:
        for line in f:
            dict_line = ast.literal_eval(line)
            contacts_dict.update(dict_line)
    return contacts_dict

def write(nested_dict, file):
    with open(file, 'w', encoding="utf-8") as f:
        for k,v in nested_dict.items():
            f.writelines(f'\n{{"{k}":{v}}}')
    print("Перезаписано")

def print_directory(nested_dict, keylist):
    for key, value in nested_dict.items():
        for arg in value.keys():
            print(f'{keylist[arg]}:   {nested_dict[key][arg]}')
        print()

def append_contact(file, keylist, cont_numbers):
    contact_info = {}
    save_line = {}
    for key, value in keylist.items():
        addition = input(f"Введите {value}: ")
        contact_info.update({key: addition})
    save_line.update({str(len(cont_numbers) + 1):contact_info})
    with open(file, 'a', encoding='utf-8') as f:
        f.write(f'\n{save_line}')
    print("Данные о контакте добавлены")

def change_contact (nested_dict, keylist, file):
    input1 = input("Для изменения контакта введите его фамилию или имя: ")
    for key, value in nested_dict.items():
        if nested_dict[key]['name'] == input1 or nested_dict[key]['surname'] == input1:
            print(f'Найдено: {" ".join(str(x) for x in nested_dict[key].values())}')
            while(input_choice_2:= int(input('Это правильный контакт? (1 - Да, 2 - Нет): '))) != 2:
                if input_choice_2 == 1:
                    for k, v in keylist.items():
                        nested_dict[key][k] = (input_2 := input(f"Введите новое значение {v} или нажмите Enter"))
    write(nested_dict, file)

def lookup_contact(nested_dict):
    input1 = input("Для поиска контакта введите его фамилию или имя: ")
    for key, value in nested_dict.items():
        if nested_dict[key]['name'] == input1 or nested_dict[key]['surname'] == input1:
            print(f'Найдено: {" ".join(str(x) for x in nested_dict[key].values())}')


def user_action():
    contacts_dict = read(contacts_file)
    cont_num_list = [int(key) for key in contacts_dict.keys()]
    cont_arg_list = dict(zip([key for key in contacts_dict['1']], ["Имя", "Отчество", "Фамилия", "Номер"]))
    print('Добро пожаловать! \n'
    '1) Вывести весь справочник\n'
    '2) Добавить контакт\n'
    '3) Найти контакт\n'
    '4) Изменить контакт\n'
    )
    while (input1:= int(input("Выберите действие (0=выход): "))) !=0:
        if input1 == 1:
            print_directory(contacts_dict, cont_arg_list)
        elif input1 == 2:
            append_contact(contacts_file, cont_arg_list, cont_num_list)
        elif input1 == 3:
            lookup_contact(contacts_dict)
        elif input1 == 4:
            change_contact(contacts_dict, cont_arg_list, contacts_file)
        else:
            print("Введено неверное значение")

user_action()
    
