__author__ = 'Michael'
###                 ###

import sys


def main():
    input_list = []
    print("Enter a word: ")
    str_input = raw_input()

    input_list.append(str_input)

    while (len(str_input) > 0):
        print("Enter a word: ")
        str_input = raw_input()
        input_list.append(str_input)
    input_list.sort(key = len)

    for word in input_list:
        print word+" ",

if __name__ == '__main__':
    main()