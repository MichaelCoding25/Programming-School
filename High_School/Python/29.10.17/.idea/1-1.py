__author__ = 'Michael'
###                 ###

import sys

def main():
    year = 0
    rightYear = 15
    print("Hello user, how old am I?")
    year = input()

    while year != rightYear:
            print "How old am I?"
            year = input()

    print "Well Done!"




if __name__ == '__main__':
    main()