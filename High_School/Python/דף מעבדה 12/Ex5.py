__author__ = 'Michael'
###                 ###

import sys

def main():
    print "Enter a number:"
    num = input()
    if (num % 13 == 0):
        print "It's a terrible number!"
    elif ((num % 14 == 0) or (num % 12 == 0)):
        print "Phew, that was close."
    else:
        print "The number is fine."




if __name__ == '__main__':
    main()