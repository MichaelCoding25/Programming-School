__author__ = 'Michael'
###                 ###

import sys

def last_char(elem):
    return elem[-1]

def main():
    l = ["michael","kise","zvika"]
    m = sorted(l, key=last_char)
    print m





if __name__ == '__main__':
    main()