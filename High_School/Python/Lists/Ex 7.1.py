__author__ = 'Michael'
###                 ###

import sys
def summer(items):
    if len(items) > 0:
        sums = items[0]
        for index in range(1,len(items)):
            sums += items[index]
        return sums
def main():
    print summer([6,6])





if __name__ == '__main__':
    main()