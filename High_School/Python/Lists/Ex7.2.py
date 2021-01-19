__author__ = 'Michael'
###                 ###

import sys

def main():

    input_list = []
    print("Enter a word: ")
    str_input = raw_input()
    input_list = []
    input_list.append(str_input)

    while(len(str_input) > 0):
        print("Enter a word: ")
        str_input = raw_input()
        input_list.append(str_input)
        
    if(("Yes" in input_list) or ("No" in input_list) or ("White" in input_list) or ("Black" in input_list)):
        print("Something is wrong")
    else:
        print("Everything is alright")






if __name__ == '__main__':
    main()