__author__ = 'Michael'
###                 ###

import sys

def main():
    for i in range (1,101):
        if (i % 7 == 0 or i / 10 == 7 or i % 10 == 7):
            print 'BOOM'
        else:
            print(i)


if __name__ == '__main__':
    main()