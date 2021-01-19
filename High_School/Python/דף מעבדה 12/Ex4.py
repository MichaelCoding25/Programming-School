__author__ = 'Michael'
###                 ###

import sys

def main():
        print "Enter a number:"
        num = input()
        if (num % 13 == 0):
            print "It's a terrible number!"
        else:
            print "You're good."



if __name__ == '__main__':
    main()