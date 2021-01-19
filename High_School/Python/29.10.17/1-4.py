__author__ = 'Michael'
###                 ###

import sys

def main():
    width = 0
    lenght = 0
    i = 1
    width_str = ""
    lenght_str = ""
    print "Enter the width of the rectangle:"
    width = input()
    print "Enter the lenght of the rectangle:"
    lenght = input()
    for i in range(1, lenght):
        width_str = "*" * width
        print width_str








if __name__ == '__main__':
    main()