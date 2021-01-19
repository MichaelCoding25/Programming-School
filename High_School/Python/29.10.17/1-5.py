__author__ = 'Michael'
###                 ###

import sys

def main():
    for i in range(100, 999):
        dig3 = i % 10
        num = i / 10
        dig2 = num % 10
        dig1 = num / 10
        num = dig1 + dig2 + dig3
        if (i % num == 0):
            print i




if __name__ == '__main__':
    main()