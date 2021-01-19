__author__ = 'Michael'
###                 ###

import sys
import math

def main():
    n = 0
    print "Please enter a number:"
    n = input()
    digits = int(math.log10(n)) + 1
    print (digits)




if __name__ == '__main__':
    main()